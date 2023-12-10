
namespace Tyuiu.AleevRI.Sprint6.Task6.V2
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
            this.panelButton_ARI = new System.Windows.Forms.Panel();
            this.panelTask_ARI = new System.Windows.Forms.Panel();
            this.panelInPut_ARI = new System.Windows.Forms.Panel();
            this.panelOutPut_ARI = new System.Windows.Forms.Panel();
            this.groupBoxTask_ARI = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_ARI = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.textBoxInPut_ARI = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_ARI = new System.Windows.Forms.TextBox();
            this.buttonLoadFile_ARI = new System.Windows.Forms.Button();
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelButton_ARI.SuspendLayout();
            this.panelTask_ARI.SuspendLayout();
            this.panelInPut_ARI.SuspendLayout();
            this.panelOutPut_ARI.SuspendLayout();
            this.groupBoxTask_ARI.SuspendLayout();
            this.groupBoxInPut_ARI.SuspendLayout();
            this.groupBoxOutPut_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton_ARI
            // 
            this.panelButton_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.panelButton_ARI.Controls.Add(this.buttonHelp_ARI);
            this.panelButton_ARI.Controls.Add(this.buttonDone_ARI);
            this.panelButton_ARI.Controls.Add(this.buttonLoadFile_ARI);
            this.panelButton_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelButton_ARI.Name = "panelButton_ARI";
            this.panelButton_ARI.Size = new System.Drawing.Size(784, 91);
            this.panelButton_ARI.TabIndex = 0;
            // 
            // panelTask_ARI
            // 
            this.panelTask_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.panelTask_ARI.Controls.Add(this.groupBoxTask_ARI);
            this.panelTask_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ARI.Location = new System.Drawing.Point(0, 91);
            this.panelTask_ARI.Name = "panelTask_ARI";
            this.panelTask_ARI.Padding = new System.Windows.Forms.Padding(2);
            this.panelTask_ARI.Size = new System.Drawing.Size(784, 73);
            this.panelTask_ARI.TabIndex = 1;
            // 
            // panelInPut_ARI
            // 
            this.panelInPut_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.panelInPut_ARI.Controls.Add(this.groupBoxInPut_ARI);
            this.panelInPut_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_ARI.Location = new System.Drawing.Point(0, 164);
            this.panelInPut_ARI.Name = "panelInPut_ARI";
            this.panelInPut_ARI.Padding = new System.Windows.Forms.Padding(3);
            this.panelInPut_ARI.Size = new System.Drawing.Size(406, 277);
            this.panelInPut_ARI.TabIndex = 2;
            // 
            // panelOutPut_ARI
            // 
            this.panelOutPut_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutPut_ARI.Controls.Add(this.splitter1);
            this.panelOutPut_ARI.Controls.Add(this.groupBoxOutPut_ARI);
            this.panelOutPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_ARI.Location = new System.Drawing.Point(406, 164);
            this.panelOutPut_ARI.Name = "panelOutPut_ARI";
            this.panelOutPut_ARI.Padding = new System.Windows.Forms.Padding(3);
            this.panelOutPut_ARI.Size = new System.Drawing.Size(378, 277);
            this.panelOutPut_ARI.TabIndex = 3;
            // 
            // groupBoxTask_ARI
            // 
            this.groupBoxTask_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxTask_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ARI.Location = new System.Drawing.Point(2, 2);
            this.groupBoxTask_ARI.Name = "groupBoxTask_ARI";
            this.groupBoxTask_ARI.Size = new System.Drawing.Size(780, 69);
            this.groupBoxTask_ARI.TabIndex = 0;
            this.groupBoxTask_ARI.TabStop = false;
            this.groupBoxTask_ARI.Text = "Условие:";
            // 
            // groupBoxInPut_ARI
            // 
            this.groupBoxInPut_ARI.Controls.Add(this.textBoxInPut_ARI);
            this.groupBoxInPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_ARI.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInPut_ARI.Name = "groupBoxInPut_ARI";
            this.groupBoxInPut_ARI.Size = new System.Drawing.Size(400, 271);
            this.groupBoxInPut_ARI.TabIndex = 0;
            this.groupBoxInPut_ARI.TabStop = false;
            this.groupBoxInPut_ARI.Text = "Ввод:";
            // 
            // groupBoxOutPut_ARI
            // 
            this.groupBoxOutPut_ARI.Controls.Add(this.textBoxOutPut_ARI);
            this.groupBoxOutPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_ARI.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutPut_ARI.Name = "groupBoxOutPut_ARI";
            this.groupBoxOutPut_ARI.Size = new System.Drawing.Size(372, 271);
            this.groupBoxOutPut_ARI.TabIndex = 0;
            this.groupBoxOutPut_ARI.TabStop = false;
            this.groupBoxOutPut_ARI.Text = "Вывод:";
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.ReadOnly = true;
            this.textBoxTask_ARI.Size = new System.Drawing.Size(774, 50);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = resources.GetString("textBoxTask_ARI.Text");
            // 
            // textBoxInPut_ARI
            // 
            this.textBoxInPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_ARI.Location = new System.Drawing.Point(3, 16);
            this.textBoxInPut_ARI.Multiline = true;
            this.textBoxInPut_ARI.Name = "textBoxInPut_ARI";
            this.textBoxInPut_ARI.ReadOnly = true;
            this.textBoxInPut_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_ARI.Size = new System.Drawing.Size(394, 252);
            this.textBoxInPut_ARI.TabIndex = 0;
            // 
            // textBoxOutPut_ARI
            // 
            this.textBoxOutPut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_ARI.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_ARI.Multiline = true;
            this.textBoxOutPut_ARI.Name = "textBoxOutPut_ARI";
            this.textBoxOutPut_ARI.ReadOnly = true;
            this.textBoxOutPut_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_ARI.Size = new System.Drawing.Size(366, 252);
            this.textBoxOutPut_ARI.TabIndex = 0;
            // 
            // buttonLoadFile_ARI
            // 
            this.buttonLoadFile_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoadFile_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile_ARI.Image")));
            this.buttonLoadFile_ARI.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadFile_ARI.Name = "buttonLoadFile_ARI";
            this.buttonLoadFile_ARI.Size = new System.Drawing.Size(75, 61);
            this.buttonLoadFile_ARI.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonLoadFile_ARI, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonLoadFile_ARI.UseVisualStyleBackColor = true;
            this.buttonLoadFile_ARI.Click += new System.EventHandler(this.buttonLoadFile_ARI_Click);
            // 
            // buttonDone_ARI
            // 
            this.buttonDone_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_ARI.Enabled = false;
            this.buttonDone_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_ARI.Image")));
            this.buttonDone_ARI.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(75, 61);
            this.buttonDone_ARI.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonDone_ARI, "Выводит второе слово каждой строки\r\nв результирующую строку\r\n");
            this.buttonDone_ARI.UseVisualStyleBackColor = true;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_ARI_Click);
            // 
            // buttonHelp_ARI
            // 
            this.buttonHelp_ARI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHelp_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_ARI.Image")));
            this.buttonHelp_ARI.Location = new System.Drawing.Point(704, 12);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp_ARI.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonHelp_ARI, "Сведения о программе");
            this.buttonHelp_ARI.UseVisualStyleBackColor = true;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_ARI_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialogTask_ARI";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 271);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panelOutPut_ARI);
            this.Controls.Add(this.panelInPut_ARI);
            this.Controls.Add(this.panelTask_ARI);
            this.Controls.Add(this.panelButton_ARI);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 2 | Алеев Р. И.";
            this.panelButton_ARI.ResumeLayout(false);
            this.panelTask_ARI.ResumeLayout(false);
            this.panelInPut_ARI.ResumeLayout(false);
            this.panelOutPut_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.PerformLayout();
            this.groupBoxInPut_ARI.ResumeLayout(false);
            this.groupBoxInPut_ARI.PerformLayout();
            this.groupBoxOutPut_ARI.ResumeLayout(false);
            this.groupBoxOutPut_ARI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
        private System.Windows.Forms.Button buttonDone_ARI;
        private System.Windows.Forms.Button buttonLoadFile_ARI;
        private System.Windows.Forms.Panel panelTask_ARI;
        private System.Windows.Forms.GroupBox groupBoxTask_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.Panel panelInPut_ARI;
        private System.Windows.Forms.GroupBox groupBoxInPut_ARI;
        private System.Windows.Forms.TextBox textBoxInPut_ARI;
        private System.Windows.Forms.Panel panelOutPut_ARI;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ARI;
        private System.Windows.Forms.TextBox textBoxOutPut_ARI;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Splitter splitter1;
    }
}

