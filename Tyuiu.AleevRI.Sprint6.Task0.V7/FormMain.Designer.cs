
namespace Tyuiu.AleevRI.Sprint6.Task0.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.groupBoxCondition_ARI = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_ARI = new System.Windows.Forms.PictureBox();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_ARI = new System.Windows.Forms.GroupBox();
            this.labelVarX_ARI = new System.Windows.Forms.Label();
            this.textBoxVarX_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_ARI = new System.Windows.Forms.GroupBox();
            this.labelResult_ARI = new System.Windows.Forms.Label();
            this.textBoxResult_ARI = new System.Windows.Forms.TextBox();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.groupBoxCondition_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ARI)).BeginInit();
            this.groupBoxInPutData_ARI.SuspendLayout();
            this.groupBoxOutPutData_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_ARI
            // 
            this.buttonDone_ARI.Location = new System.Drawing.Point(349, 403);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(160, 35);
            this.buttonDone_ARI.TabIndex = 0;
            this.buttonDone_ARI.Text = "Выполнить";
            this.buttonDone_ARI.UseVisualStyleBackColor = true;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxCondition_ARI
            // 
            this.groupBoxCondition_ARI.Controls.Add(this.pictureBoxFormula_ARI);
            this.groupBoxCondition_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxCondition_ARI.Location = new System.Drawing.Point(21, 27);
            this.groupBoxCondition_ARI.Name = "groupBoxCondition_ARI";
            this.groupBoxCondition_ARI.Size = new System.Drawing.Size(498, 236);
            this.groupBoxCondition_ARI.TabIndex = 1;
            this.groupBoxCondition_ARI.TabStop = false;
            this.groupBoxCondition_ARI.Text = "Условие";
            // 
            // pictureBoxFormula_ARI
            // 
            this.pictureBoxFormula_ARI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_ARI.Image")));
            this.pictureBoxFormula_ARI.Location = new System.Drawing.Point(341, 27);
            this.pictureBoxFormula_ARI.Name = "pictureBoxFormula_ARI";
            this.pictureBoxFormula_ARI.Size = new System.Drawing.Size(137, 69);
            this.pictureBoxFormula_ARI.TabIndex = 1;
            this.pictureBoxFormula_ARI.TabStop = false;
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ARI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(15, 19);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.Size = new System.Drawing.Size(345, 77);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPutData_ARI
            // 
            this.groupBoxInPutData_ARI.Controls.Add(this.labelVarX_ARI);
            this.groupBoxInPutData_ARI.Controls.Add(this.textBoxVarX_ARI);
            this.groupBoxInPutData_ARI.Location = new System.Drawing.Point(21, 289);
            this.groupBoxInPutData_ARI.Name = "groupBoxInPutData_ARI";
            this.groupBoxInPutData_ARI.Size = new System.Drawing.Size(277, 103);
            this.groupBoxInPutData_ARI.TabIndex = 2;
            this.groupBoxInPutData_ARI.TabStop = false;
            this.groupBoxInPutData_ARI.Text = "Ввод данных";
            // 
            // labelVarX_ARI
            // 
            this.labelVarX_ARI.AutoSize = true;
            this.labelVarX_ARI.Location = new System.Drawing.Point(12, 26);
            this.labelVarX_ARI.Name = "labelVarX_ARI";
            this.labelVarX_ARI.Size = new System.Drawing.Size(90, 13);
            this.labelVarX_ARI.TabIndex = 1;
            this.labelVarX_ARI.Text = "Переменнная X:";
            // 
            // textBoxVarX_ARI
            // 
            this.textBoxVarX_ARI.Location = new System.Drawing.Point(15, 52);
            this.textBoxVarX_ARI.Name = "textBoxVarX_ARI";
            this.textBoxVarX_ARI.Size = new System.Drawing.Size(87, 20);
            this.textBoxVarX_ARI.TabIndex = 0;
            this.textBoxVarX_ARI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInVarX_KeyPress);
            // 
            // groupBoxOutPutData_ARI
            // 
            this.groupBoxOutPutData_ARI.Controls.Add(this.labelResult_ARI);
            this.groupBoxOutPutData_ARI.Controls.Add(this.textBoxResult_ARI);
            this.groupBoxOutPutData_ARI.Location = new System.Drawing.Point(304, 289);
            this.groupBoxOutPutData_ARI.Name = "groupBoxOutPutData_ARI";
            this.groupBoxOutPutData_ARI.Size = new System.Drawing.Size(215, 103);
            this.groupBoxOutPutData_ARI.TabIndex = 3;
            this.groupBoxOutPutData_ARI.TabStop = false;
            this.groupBoxOutPutData_ARI.Text = "Вывод данных";
            // 
            // labelResult_ARI
            // 
            this.labelResult_ARI.AutoSize = true;
            this.labelResult_ARI.Location = new System.Drawing.Point(3, 26);
            this.labelResult_ARI.Name = "labelResult_ARI";
            this.labelResult_ARI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ARI.TabIndex = 1;
            this.labelResult_ARI.Text = "Результат:";
            // 
            // textBoxResult_ARI
            // 
            this.textBoxResult_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_ARI.Location = new System.Drawing.Point(6, 52);
            this.textBoxResult_ARI.Name = "textBoxResult_ARI";
            this.textBoxResult_ARI.Size = new System.Drawing.Size(199, 20);
            this.textBoxResult_ARI.TabIndex = 0;
            // 
            // buttonHelp_ARI
            // 
            this.buttonHelp_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ARI.Location = new System.Drawing.Point(310, 403);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(35, 35);
            this.buttonHelp_ARI.TabIndex = 4;
            this.buttonHelp_ARI.Text = "?";
            this.buttonHelp_ARI.UseVisualStyleBackColor = true;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.buttonHelp_ARI);
            this.Controls.Add(this.groupBoxOutPutData_ARI);
            this.Controls.Add(this.groupBoxInPutData_ARI);
            this.Controls.Add(this.groupBoxCondition_ARI);
            this.Controls.Add(this.buttonDone_ARI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 7 | Алеев Р. И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_ARI.ResumeLayout(false);
            this.groupBoxCondition_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ARI)).EndInit();
            this.groupBoxInPutData_ARI.ResumeLayout(false);
            this.groupBoxInPutData_ARI.PerformLayout();
            this.groupBoxOutPutData_ARI.ResumeLayout(false);
            this.groupBoxOutPutData_ARI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_ARI;
        private System.Windows.Forms.GroupBox groupBoxCondition_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.PictureBox pictureBoxFormula_ARI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_ARI;
        private System.Windows.Forms.Label labelVarX_ARI;
        private System.Windows.Forms.TextBox textBoxVarX_ARI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_ARI;
        private System.Windows.Forms.Label labelResult_ARI;
        private System.Windows.Forms.TextBox textBoxResult_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
    }
}

