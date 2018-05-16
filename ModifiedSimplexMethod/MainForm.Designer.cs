namespace FractionalProgramming
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpData = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMatr = new System.Windows.Forms.CheckBox();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.tbEqs = new System.Windows.Forms.TextBox();
            this.tbVars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbIters = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doCalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mdgvD = new FractionalProgramming.MatrixDataGridView();
            this.mdgvPs = new FractionalProgramming.MatrixDataGridView();
            this.mdgvB = new FractionalProgramming.MatrixDataGridView();
            this.mdgvC = new FractionalProgramming.MatrixDataGridView();
            this.tabControl1.SuspendLayout();
            this.tpData.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpResults.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpData);
            this.tabControl1.Controls.Add(this.tpResults);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tpData
            // 
            this.tpData.Controls.Add(this.groupBox7);
            this.tpData.Controls.Add(this.splitContainer1);
            this.tpData.Controls.Add(this.groupBox2);
            this.tpData.Controls.Add(this.groupBox1);
            this.tpData.Location = new System.Drawing.Point(4, 22);
            this.tpData.Name = "tpData";
            this.tpData.Padding = new System.Windows.Forms.Padding(3);
            this.tpData.Size = new System.Drawing.Size(622, 293);
            this.tpData.TabIndex = 0;
            this.tpData.Text = "Данные";
            this.tpData.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.mdgvD);
            this.groupBox7.Location = new System.Drawing.Point(274, 78);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(343, 45);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Коэффициенты знаменателя целевой функции";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 129);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(607, 156);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mdgvPs);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 156);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Коэффициенты ограничений";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mdgvB);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 156);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Свободные члены";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mdgvC);
            this.groupBox2.Location = new System.Drawing.Point(274, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 45);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коэффициенты числителя целевой функции";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMatr);
            this.groupBox1.Controls.Add(this.cbMax);
            this.groupBox1.Controls.Add(this.tbEqs);
            this.groupBox1.Controls.Add(this.tbVars);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид задачи";
            // 
            // cbMatr
            // 
            this.cbMatr.AutoSize = true;
            this.cbMatr.Location = new System.Drawing.Point(9, 91);
            this.cbMatr.Name = "cbMatr";
            this.cbMatr.Size = new System.Drawing.Size(214, 17);
            this.cbMatr.TabIndex = 7;
            this.cbMatr.Text = "Автозаполнение единичной матрицы";
            this.cbMatr.UseVisualStyleBackColor = true;
            this.cbMatr.CheckedChanged += new System.EventHandler(this.cbMatr_CheckedChanged);
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Checked = true;
            this.cbMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMax.Location = new System.Drawing.Point(9, 70);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(220, 17);
            this.cbMax.TabIndex = 6;
            this.cbMax.Text = "Максимизация (иначе - минимизация)";
            this.cbMax.UseVisualStyleBackColor = true;
            // 
            // tbEqs
            // 
            this.tbEqs.Location = new System.Drawing.Point(147, 45);
            this.tbEqs.Name = "tbEqs";
            this.tbEqs.Size = new System.Drawing.Size(100, 20);
            this.tbEqs.TabIndex = 5;
            this.tbEqs.Leave += new System.EventHandler(this.tbVars_tbEqs_Leave);
            // 
            // tbVars
            // 
            this.tbVars.Location = new System.Drawing.Point(147, 19);
            this.tbVars.Name = "tbVars";
            this.tbVars.Size = new System.Drawing.Size(100, 20);
            this.tbVars.TabIndex = 4;
            this.tbVars.Leave += new System.EventHandler(this.tbVars_tbEqs_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество переменных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество ограничений:";
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.splitContainer2);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(622, 293);
            this.tpResults.TabIndex = 1;
            this.tpResults.Text = "Результаты";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer2.Size = new System.Drawing.Size(616, 287);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbIters);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 287);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Итерации";
            // 
            // lbIters
            // 
            this.lbIters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIters.FormattingEnabled = true;
            this.lbIters.Location = new System.Drawing.Point(3, 16);
            this.lbIters.Name = "lbIters";
            this.lbIters.Size = new System.Drawing.Size(239, 264);
            this.lbIters.TabIndex = 0;
            this.lbIters.SelectedValueChanged += new System.EventHandler(this.lbIters_SelectedValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.webBrowser1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 287);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Описание итерации";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(3, 16);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(361, 268);
            this.webBrowser1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Сохранить...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doCalculateToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.calculateToolStripMenuItem.Text = "Вычисления";
            // 
            // doCalculateToolStripMenuItem
            // 
            this.doCalculateToolStripMenuItem.Name = "doCalculateToolStripMenuItem";
            this.doCalculateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.doCalculateToolStripMenuItem.Text = "Оптимизировать";
            this.doCalculateToolStripMenuItem.Click += new System.EventHandler(this.doCalculateToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.contentsToolStripMenuItem.Text = "Содержание";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Задача1.msm";
            this.saveFileDialog1.Filter = "Файл задачи | *.msm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Файл задачи | *.msm";
            // 
            // mdgvD
            // 
            this.mdgvD.AllowUserToAddRows = false;
            this.mdgvD.AllowUserToDeleteRows = false;
            this.mdgvD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvD.BackgroundColor = System.Drawing.Color.LightGray;
            this.mdgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvD.ColumnHeadersVisible = false;
            this.mdgvD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdgvD.Location = new System.Drawing.Point(3, 16);
            this.mdgvD.Matrix = null;
            this.mdgvD.Name = "mdgvD";
            this.mdgvD.RowHeadersVisible = false;
            this.mdgvD.Size = new System.Drawing.Size(337, 26);
            this.mdgvD.TabIndex = 0;
            // 
            // mdgvPs
            // 
            this.mdgvPs.AllowUserToAddRows = false;
            this.mdgvPs.AllowUserToDeleteRows = false;
            this.mdgvPs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvPs.BackgroundColor = System.Drawing.Color.LightGray;
            this.mdgvPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvPs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdgvPs.Location = new System.Drawing.Point(3, 16);
            this.mdgvPs.Matrix = null;
            this.mdgvPs.Name = "mdgvPs";
            this.mdgvPs.RowHeadersVisible = false;
            this.mdgvPs.Size = new System.Drawing.Size(475, 137);
            this.mdgvPs.TabIndex = 0;
            // 
            // mdgvB
            // 
            this.mdgvB.AllowUserToAddRows = false;
            this.mdgvB.AllowUserToDeleteRows = false;
            this.mdgvB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvB.BackgroundColor = System.Drawing.Color.LightGray;
            this.mdgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvB.ColumnHeadersVisible = false;
            this.mdgvB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdgvB.Location = new System.Drawing.Point(3, 16);
            this.mdgvB.Matrix = null;
            this.mdgvB.Name = "mdgvB";
            this.mdgvB.RowHeadersVisible = false;
            this.mdgvB.Size = new System.Drawing.Size(116, 137);
            this.mdgvB.TabIndex = 0;
            // 
            // mdgvC
            // 
            this.mdgvC.AllowUserToAddRows = false;
            this.mdgvC.AllowUserToDeleteRows = false;
            this.mdgvC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvC.BackgroundColor = System.Drawing.Color.LightGray;
            this.mdgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvC.ColumnHeadersVisible = false;
            this.mdgvC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdgvC.Location = new System.Drawing.Point(3, 16);
            this.mdgvC.Matrix = null;
            this.mdgvC.Name = "mdgvC";
            this.mdgvC.RowHeadersVisible = false;
            this.mdgvC.Size = new System.Drawing.Size(337, 26);
            this.mdgvC.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(591, 268);
            this.Name = "MainForm";
            this.Text = "Дробно-линейное программирование";
            this.tabControl1.ResumeLayout(false);
            this.tpData.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpResults.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private MatrixDataGridView mdgvC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEqs;
        private System.Windows.Forms.TextBox tbVars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MatrixDataGridView mdgvPs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MatrixDataGridView mdgvB;
        private System.Windows.Forms.TabPage tpResults;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doCalculateToolStripMenuItem;
        private System.Windows.Forms.ListBox lbIters;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox7;
        private MatrixDataGridView mdgvD;
        private System.Windows.Forms.CheckBox cbMatr;


    }
}

