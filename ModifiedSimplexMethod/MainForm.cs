using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FractionalProgramming
{
    public partial class MainForm : Form
    {
        int varCount, eqCount, varCountDefault = 4, eqCountDefault = 3;
        ExMatrix C, D, b;
        ExMatrix[] Ps;
        ArrayList states;
        public MainForm()
        {
            InitializeComponent();
            varCount = varCountDefault;
            eqCount = eqCountDefault;
            tbVars.Text = varCount.ToString();
            tbEqs.Text = eqCount.ToString();
            ApplyDimChange();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tbVars_tbEqs_Leave(object sender, EventArgs e)
        {
            int varCountNew = -1;
            int eqCountNew = -1;
            try
            {
                varCountNew = int.Parse(tbVars.Text);
                eqCountNew = int.Parse(tbEqs.Text);
                if (varCountNew <= eqCountNew)
                    throw new Exception();
            }
            catch
            {
                varCountNew = varCount;
                eqCountNew = eqCount;
                tbVars.Text = varCount.ToString();
                tbEqs.Text = eqCount.ToString();
            }
            if (varCountNew != varCount ||
                eqCountNew != eqCount)
            {
                varCount = varCountNew;
                eqCount = eqCountNew;
                try
                {
                    ApplyDimChange();
                }
                catch
                {
                    varCount = varCountDefault;
                    eqCount = eqCountDefault;
                    ApplyDimChange();
                }
            }
        }
        private void doCalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReadData() == false)
                return;
            if (cbMax.Checked == false)
            {
                for (int i = 0; i < varCount; i++)
                    C.Elements[0, i] *= -1;
            }
            lbIters.Items.Clear();
            webBrowser1.DocumentText = "<P>Вычисления не завершены</P>";

            ExMatrix[] PsEx = new ExMatrix[varCount + 1];
            for (int j = 0; j < varCount; j++)
            {
                ExMatrix matr = new ExMatrix(eqCount + 1, 1);
                for (int i = 0; i < eqCount; i++)
                    matr.Elements[i, 0] = Ps[j].Elements[i, 0];
                matr.Elements[eqCount, 0] = D.Elements[0, j];
                PsEx[j] = matr;
            }
            PsEx[varCount] = new ExMatrix(eqCount + 1, 1);
            for (int i = 0; i < eqCount; i++)
                PsEx[varCount].Elements[i, 0] = -b.Elements[i, 0];
            PsEx[varCount].Elements[eqCount, 0] = 0;
            ExMatrix bEx = new ExMatrix(eqCount + 1, 1);
            bEx.Elements[eqCount, 0] = 1;
            ExMatrix CEx = new ExMatrix(1, varCount + 1);
            for (int j = 0; j < varCount; j++)
                CEx.Elements[0, j] = C.Elements[0, j];
            CEx.Elements[0, varCount] = 0;

            MsMethod m = new MsMethod(PsEx, bEx, CEx, 0);
            SelectBasIndForm sForm = new SelectBasIndForm(varCount + 1, eqCount + 1, m);
            if (sForm.ShowDialog() == DialogResult.Cancel)
                return;
            int[] basInd = sForm.GetBasInd();
            try
            {
                m.SetBasis(basInd);
                while (m.DoIteration()) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Вычисления прерваны: " + ex.Message,
                    "Прерывание вычислений", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            states = m.states;
            lbIters.SuspendLayout();
            for (int i = 0; i < states.Count; i++)
            {
                IterationState s = states[i] as IterationState;
                int iterNum = i + 1;
                string str = iterNum.ToString();
                if (s.isDecisionLegal)
                    str += " (F = " + s.GetFuncValue().ToString() + ", допустимое решение)";
                else
                    str += " (F = " + s.GetFuncValue().ToString() + ", недопустимое решение)";
                lbIters.Items.Add(str);
            }
            lbIters.ResumeLayout();
            webBrowser1.DocumentText = (m.states[0] as IterationState).GetReport();
            tabControl1.SelectedIndex = 1;
            if (cbMax.Checked == false)
                MessageBox.Show("Поскольку требуется минимизация, " +
                    "целевая функция была умножена на -1, и далее " +
                    "произведена максимизация",
                    "Целевая функция умножена на -1", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
        private void ApplyDimChange()
        {
            tbVars.Text = varCount.ToString();
            tbEqs.Text = eqCount.ToString();
            C = new ExMatrix(1, varCount);
            D = new ExMatrix(1, varCount);
            b = new ExMatrix(eqCount, 1);
            Ps = new ExMatrix[varCount];
            for (int i = 0; i < varCount; i++)
                Ps[i] = new ExMatrix(eqCount, 1);
            mdgvC.Matrix = C;
            mdgvD.Matrix = D;
            mdgvB.Matrix = b;
            mdgvPs.Matrix = new ExMatrix(Ps);
            lbIters.Items.Clear();
            cbMatr_CheckedChanged(null, null);
            webBrowser1.DocumentText = "<P>Для начала работы с программой " +
                "введите исходные данные</P>";
        }
        private bool ReadData()
        {
            try
            {
                C = mdgvC.Matrix;
                D = mdgvD.Matrix;
                b = mdgvB.Matrix;
                ExMatrix P = mdgvPs.Matrix;
                Ps = new ExMatrix[varCount];
                for (int j = 0; j < varCount; j++)
                {
                    Ps[j] = new ExMatrix(eqCount, 1);
                    for (int i = 0; i < eqCount; i++)
                        Ps[j].Elements[i, 0] = P.Elements[i, j];
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных. Проверьте наличие " +
                    "пустых элементов матриц и значение коэффициента " +
                    "целевой функции при свободном члене",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void lbIters_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = lbIters.SelectedIndex;
            if (states == null || i < 0 ||
                i >= states.Count || states.Count == 0)
                return;
            IterationState s = states[i] as IterationState;
            webBrowser1.DocumentText = s.GetReport();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
        private void SaveFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            StreamWriter w = new StreamWriter(fs, Encoding.Default);
            w.WriteLine("Переменных " + varCount.ToString());
            w.WriteLine("Ограничений " + eqCount.ToString());
            w.WriteLine("Матрица С");
            C.StreamWrite(w);
            w.WriteLine("Матрица D");
            D.StreamWrite(w);
            w.WriteLine("Матрица b");
            b.StreamWrite(w);
            for (int i = 0; i < Ps.Length; i++)
            {
                ExMatrix P = Ps[i] as ExMatrix;
                w.WriteLine("Матрица P" + i.ToString());
                P.StreamWrite(w);
            }            
            w.Close();
        }
        private void OpenFile(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(fs, Encoding.Default);
            char[] sep = new char[4] { ' ', '\t', '\r', '\n' };
            string[] arrStr = r.ReadLine().Split(sep);
            varCount = (int)int.Parse(arrStr[1]);
            arrStr = r.ReadLine().Split(sep);
            eqCount = (int)int.Parse(arrStr[1]);
            ApplyDimChange();
            r.ReadLine();
            C.StreamRead(r);
            r.ReadLine();
            D.StreamRead(r);
            r.ReadLine();
            b.StreamRead(r);
            Ps = new ExMatrix[varCount];
            for (int i = 0; i < Ps.Length; i++)
            {
                r.ReadLine();
                Ps[i] = new ExMatrix(r);                
            }
            mdgvC.Matrix = C;
            mdgvD.Matrix = D;
            mdgvB.Matrix = b;
            mdgvPs.Matrix = new ExMatrix(Ps);
            r.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReadData() == false)
                    return;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveFile(saveFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла",
                    "Ошибка сохранения", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    OpenFile(openFileDialog1.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла",
                    "Ошибка открытия", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }
        private void cbMatr_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMatr.Checked)
            {
                for (int i = 0; i < eqCount; i++)
                    mdgvPs.Columns[varCount - 1 - i].Visible = false;
                ExMatrix matr = mdgvPs.Matrix;
                for (int i = 0; i < eqCount; i++)
                    for (int j = 0; j < eqCount; j++)
                        if (i == j)
                            matr.Elements[i, j + (varCount - eqCount)] = 1;
                        else
                            matr.Elements[i, j + (varCount - eqCount)] = 0;
                mdgvPs.Matrix = matr;
            }
            else
                for (int i = 0; i < eqCount; i++)
                    mdgvPs.Columns[varCount - 1 - i].Visible = true;
        }
    }
    public class MatrixDataGridView : DataGridView
    {
        public ExMatrix Matrix
        {
            set
            {
                if (value == null)
                    return;
                if (Rows.Count != value.M ||
                    Columns.Count != value.N)
                {
                    SuspendLayout();
                    Rows.Clear();
                    Columns.Clear();
                    for (int j = 0; j < value.N; j++)
                    {
                        DataGridViewColumn c =
                            new DataGridViewColumn(new DataGridViewTextBoxCell());
                        c.ValueType = typeof(double);
                        Columns.Add(c);
                    }
                    Rows.Add(value.M);
                    for (int i = 0; i < value.M; i++)
                        for (int j = 0; j < value.N; j++)
                            Rows[i].Cells[j].Value = value.Elements[i, j];
                    ResumeLayout();
                }
                else
                {
                    for (int i = 0; i < value.M; i++)
                        for (int j = 0; j < value.N; j++)
                            Rows[i].Cells[j].Value = value.Elements[i, j];
                }
            }
            get
            {
                if (Rows.Count == 0 || Columns.Count == 0)
                    return null;
                ExMatrix res = new ExMatrix(Rows.Count, Columns.Count);
                for (int i = 0; i < Rows.Count; i++)
                    for (int j = 0; j < Columns.Count; j++)
                        res.Elements[i, j] = (double)Rows[i].Cells[j].Value;
                return res;
            }
        }
        public MatrixDataGridView()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ColumnHeadersVisible = false;
            this.RowHeadersVisible = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSize = true;
            this.BackgroundColor = Color.LightGray;
        }
        protected override void OnDataError(bool displayErrorDialogIfNoHandler,
            DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных. Для дробных чисел используйте зяпятую",
                "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            base.OnDataError(false, e);
        }
    }
}