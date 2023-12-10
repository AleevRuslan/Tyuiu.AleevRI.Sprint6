
namespace Tyuiu.AleevRI.Sprint6.Task7.V22
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelForButtons_ARI = new System.Windows.Forms.Panel();
            this.buttonInfo_ARI = new System.Windows.Forms.Button();
            this.buttonSave_ARI = new System.Windows.Forms.Button();
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ARI = new System.Windows.Forms.Button();
            this.panelForTask_ARI = new System.Windows.Forms.Panel();
            this.groupBoxTask_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.panelOutPut_ARI = new System.Windows.Forms.Panel();
            this.panelInPut_ARI = new System.Windows.Forms.Panel();
            this.groupBoxInPut_ARI = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_ARI = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxOutPut_ARI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_ARI = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_ARI = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButtons_ARI = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_ARI = new System.Windows.Forms.SaveFileDialog();
            this.panelForButtons_ARI.SuspendLayout();
            this.panelForTask_ARI.SuspendLayout();
            this.groupBoxTask_ARI.SuspendLayout();
            this.panelInPut_ARI.SuspendLayout();
            this.groupBoxInPut_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_ARI)).BeginInit();
            this.groupBoxOutPut_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ARI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForButtons_ARI
            // 
            this.panelForButtons_ARI.Controls.Add(this.buttonInfo_ARI);
            this.panelForButtons_ARI.Controls.Add(this.buttonSave_ARI);
            this.panelForButtons_ARI.Controls.Add(this.buttonDone_ARI);
            this.panelForButtons_ARI.Controls.Add(this.buttonOpenFile_ARI);
            this.panelForButtons_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForButtons_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelForButtons_ARI.Name = "panelForButtons_ARI";
            this.panelForButtons_ARI.Size = new System.Drawing.Size(794, 100);
            this.panelForButtons_ARI.TabIndex = 0;
            // 
            // buttonInfo_ARI
            // 
            this.buttonInfo_ARI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_ARI.Image")));
            this.buttonInfo_ARI.Location = new System.Drawing.Point(655, 12);
            this.buttonInfo_ARI.Name = "buttonInfo_ARI";
            this.buttonInfo_ARI.Size = new System.Drawing.Size(75, 70);
            this.buttonInfo_ARI.TabIndex = 3;
            this.toolTipButtons_ARI.SetToolTip(this.buttonInfo_ARI, "Сведения о программе");
            this.buttonInfo_ARI.UseVisualStyleBackColor = true;
            this.buttonInfo_ARI.Click += new System.EventHandler(this.buttonInfo_ARI_Click);
            this.buttonInfo_ARI.MouseEnter += new System.EventHandler(this.buttonInfo_ARI_MouseEnter);
            // 
            // buttonSave_ARI
            // 
            this.buttonSave_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_ARI.Enabled = false;
            this.buttonSave_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_ARI.Image")));
            this.buttonSave_ARI.Location = new System.Drawing.Point(176, 12);
            this.buttonSave_ARI.Name = "buttonSave_ARI";
            this.buttonSave_ARI.Size = new System.Drawing.Size(75, 70);
            this.buttonSave_ARI.TabIndex = 2;
            this.toolTipButtons_ARI.SetToolTip(this.buttonSave_ARI, "Сохранить исходный файл");
            this.buttonSave_ARI.UseVisualStyleBackColor = true;
            this.buttonSave_ARI.Click += new System.EventHandler(this.buttonSave_ARI_Click);
            this.buttonSave_ARI.MouseEnter += new System.EventHandler(this.buttonSave_ARI_MouseEnter);
            // 
            // buttonDone_ARI
            // 
            this.buttonDone_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_ARI.Enabled = false;
            this.buttonDone_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_ARI.Image")));
            this.buttonDone_ARI.Location = new System.Drawing.Point(95, 12);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(75, 70);
            this.buttonDone_ARI.TabIndex = 1;
            this.toolTipButtons_ARI.SetToolTip(this.buttonDone_ARI, "Выполнить обработку данных");
            this.buttonDone_ARI.UseVisualStyleBackColor = true;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_ARI_Click);
            this.buttonDone_ARI.MouseEnter += new System.EventHandler(this.buttonDone_ARI_MouseEnter);
            // 
            // buttonOpenFile_ARI
            // 
            this.buttonOpenFile_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_ARI.Image")));
            this.buttonOpenFile_ARI.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_ARI.Name = "buttonOpenFile_ARI";
            this.buttonOpenFile_ARI.Size = new System.Drawing.Size(77, 70);
            this.buttonOpenFile_ARI.TabIndex = 0;
            this.toolTipButtons_ARI.SetToolTip(this.buttonOpenFile_ARI, "Открыть файл");
            this.buttonOpenFile_ARI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ARI.Click += new System.EventHandler(this.buttonOpenFile_ARI_Click);
            this.buttonOpenFile_ARI.MouseEnter += new System.EventHandler(this.buttonOpenFile_ARI_MouseEnter);
            // 
            // panelForTask_ARI
            // 
            this.panelForTask_ARI.Controls.Add(this.groupBoxTask_ARI);
            this.panelForTask_ARI.Controls.Add(this.panelOutPut_ARI);
            this.panelForTask_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForTask_ARI.Location = new System.Drawing.Point(0, 100);
            this.panelForTask_ARI.Name = "panelForTask_ARI";
            this.panelForTask_ARI.Size = new System.Drawing.Size(794, 100);
            this.panelForTask_ARI.TabIndex = 1;
            // 
            // groupBoxTask_ARI
            // 
            this.groupBoxTask_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxTask_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ARI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ARI.Name = "groupBoxTask_ARI";
            this.groupBoxTask_ARI.Size = new System.Drawing.Size(794, 100);
            this.groupBoxTask_ARI.TabIndex = 4;
            this.groupBoxTask_ARI.TabStop = false;
            this.groupBoxTask_ARI.Text = "Условие:";
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.ReadOnly = true;
            this.textBoxTask_ARI.Size = new System.Drawing.Size(788, 81);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = resources.GetString("textBoxTask_ARI.Text");
            // 
            // panelOutPut_ARI
            // 
            this.panelOutPut_ARI.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelOutPut_ARI.Location = new System.Drawing.Point(367, 100);
            this.panelOutPut_ARI.Name = "panelOutPut_ARI";
            this.panelOutPut_ARI.Size = new System.Drawing.Size(427, 241);
            this.panelOutPut_ARI.TabIndex = 3;
            // 
            // panelInPut_ARI
            // 
            this.panelInPut_ARI.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInPut_ARI.Controls.Add(this.groupBoxInPut_ARI);
            this.panelInPut_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_ARI.Location = new System.Drawing.Point(0, 200);
            this.panelInPut_ARI.Name = "panelInPut_ARI";
            this.panelInPut_ARI.Size = new System.Drawing.Size(367, 241);
            this.panelInPut_ARI.TabIndex = 2;
            // 
            // groupBoxInPut_ARI
            // 
            this.groupBoxInPut_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxInPut_ARI.Controls.Add(this.dataGridViewInPut_ARI);
            this.groupBoxInPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_ARI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_ARI.Name = "groupBoxInPut_ARI";
            this.groupBoxInPut_ARI.Size = new System.Drawing.Size(367, 241);
            this.groupBoxInPut_ARI.TabIndex = 0;
            this.groupBoxInPut_ARI.TabStop = false;
            this.groupBoxInPut_ARI.Text = "Ввод:";
            // 
            // dataGridViewInPut_ARI
            // 
            this.dataGridViewInPut_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_ARI.ColumnHeadersVisible = false;
            this.dataGridViewInPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_ARI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_ARI.Name = "dataGridViewInPut_ARI";
            this.dataGridViewInPut_ARI.ReadOnly = true;
            this.dataGridViewInPut_ARI.RowHeadersVisible = false;
            this.dataGridViewInPut_ARI.Size = new System.Drawing.Size(361, 222);
            this.dataGridViewInPut_ARI.TabIndex = 0;
            this.dataGridViewInPut_ARI.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(367, 200);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 241);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // groupBoxOutPut_ARI
            // 
            this.groupBoxOutPut_ARI.Controls.Add(this.dataGridViewOutPut_ARI);
            this.groupBoxOutPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_ARI.Location = new System.Drawing.Point(370, 200);
            this.groupBoxOutPut_ARI.Name = "groupBoxOutPut_ARI";
            this.groupBoxOutPut_ARI.Size = new System.Drawing.Size(424, 241);
            this.groupBoxOutPut_ARI.TabIndex = 5;
            this.groupBoxOutPut_ARI.TabStop = false;
            this.groupBoxOutPut_ARI.Text = "Вывод:";
            // 
            // dataGridViewOutPut_ARI
            // 
            this.dataGridViewOutPut_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_ARI.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_ARI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_ARI.Name = "dataGridViewOutPut_ARI";
            this.dataGridViewOutPut_ARI.ReadOnly = true;
            this.dataGridViewOutPut_ARI.RowHeadersVisible = false;
            this.dataGridViewOutPut_ARI.Size = new System.Drawing.Size(418, 222);
            this.dataGridViewOutPut_ARI.TabIndex = 0;
            this.dataGridViewOutPut_ARI.TabStop = false;
            // 
            // openFileDialogTask_ARI
            // 
            this.openFileDialogTask_ARI.FileName = "openFileDialog1";
            // 
            // toolTipButtons_ARI
            // 
            this.toolTipButtons_ARI.IsBalloon = true;
            this.toolTipButtons_ARI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.groupBoxOutPut_ARI);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelInPut_ARI);
            this.Controls.Add(this.panelForTask_ARI);
            this.Controls.Add(this.panelForButtons_ARI);
            this.MinimumSize = new System.Drawing.Size(810, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 28 | Алеев Р. И";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelForButtons_ARI.ResumeLayout(false);
            this.panelForTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.PerformLayout();
            this.panelInPut_ARI.ResumeLayout(false);
            this.groupBoxInPut_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_ARI)).EndInit();
            this.groupBoxOutPut_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_ARI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForButtons_ARI;
        private System.Windows.Forms.Panel panelForTask_ARI;
        private System.Windows.Forms.Panel panelInPut_ARI;
        private System.Windows.Forms.Panel panelOutPut_ARI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxInPut_ARI;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ARI;
        private System.Windows.Forms.Button buttonInfo_ARI;
        private System.Windows.Forms.Button buttonSave_ARI;
        private System.Windows.Forms.Button buttonDone_ARI;
        private System.Windows.Forms.Button buttonOpenFile_ARI;
        private System.Windows.Forms.GroupBox groupBoxTask_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.DataGridView dataGridViewInPut_ARI;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_ARI;
        private System.Windows.Forms.ToolTip toolTipButtons_ARI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_ARI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_ARI;
    }
}

