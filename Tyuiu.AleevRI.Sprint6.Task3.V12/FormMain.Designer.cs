
namespace Tyuiu.AleevRI.Sprint6.Task3.V12
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
            this.groupBoxTask_ARI = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_ARI = new System.Windows.Forms.DataGridView();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_ARI = new System.Windows.Forms.GroupBox();
            this.labelResult_ARI = new System.Windows.Forms.Label();
            this.buttonInfo_ARI = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.dataGridViewResult_ARI = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ARI)).BeginInit();
            this.groupBoxResult_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ARI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ARI
            // 
            this.groupBoxTask_ARI.Controls.Add(this.dataGridViewMatrix_ARI);
            this.groupBoxTask_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxTask_ARI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ARI.Name = "groupBoxTask_ARI";
            this.groupBoxTask_ARI.Size = new System.Drawing.Size(534, 254);
            this.groupBoxTask_ARI.TabIndex = 0;
            this.groupBoxTask_ARI.TabStop = false;
            this.groupBoxTask_ARI.Text = "Условие";
            // 
            // dataGridViewMatrix_ARI
            // 
            this.dataGridViewMatrix_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_ARI.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_ARI.Location = new System.Drawing.Point(295, 19);
            this.dataGridViewMatrix_ARI.Name = "dataGridViewMatrix_ARI";
            this.dataGridViewMatrix_ARI.RowHeadersVisible = false;
            this.dataGridViewMatrix_ARI.Size = new System.Drawing.Size(224, 218);
            this.dataGridViewMatrix_ARI.TabIndex = 0;
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ARI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.ReadOnly = true;
            this.textBoxTask_ARI.Size = new System.Drawing.Size(283, 218);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = "Дан массив 5 на 5 элементов\r\n -6 -13  -1  -7  10\r\n\r\n  14 -18  18   1  11\r\n\r\n -2 -" +
    "17 -15 -10  -8\r\n\r\n  19  -4  -6 -11   8\r\n\r\n -17  17  14  13  19\r\n\r\nЗаменить четны" +
    "е значения в первой строке на 0";
            // 
            // groupBoxResult_ARI
            // 
            this.groupBoxResult_ARI.Controls.Add(this.dataGridViewResult_ARI);
            this.groupBoxResult_ARI.Controls.Add(this.labelResult_ARI);
            this.groupBoxResult_ARI.Location = new System.Drawing.Point(552, 12);
            this.groupBoxResult_ARI.Name = "groupBoxResult_ARI";
            this.groupBoxResult_ARI.Size = new System.Drawing.Size(163, 254);
            this.groupBoxResult_ARI.TabIndex = 1;
            this.groupBoxResult_ARI.TabStop = false;
            this.groupBoxResult_ARI.Text = "Вывод данных";
            // 
            // labelResult_ARI
            // 
            this.labelResult_ARI.AutoSize = true;
            this.labelResult_ARI.Location = new System.Drawing.Point(7, 20);
            this.labelResult_ARI.Name = "labelResult_ARI";
            this.labelResult_ARI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_ARI.TabIndex = 1;
            this.labelResult_ARI.Text = "Результат:";
            // 
            // buttonInfo_ARI
            // 
            this.buttonInfo_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_ARI.Location = new System.Drawing.Point(562, 272);
            this.buttonInfo_ARI.Name = "buttonInfo_ARI";
            this.buttonInfo_ARI.Size = new System.Drawing.Size(35, 35);
            this.buttonInfo_ARI.TabIndex = 2;
            this.buttonInfo_ARI.Text = "?";
            this.buttonInfo_ARI.UseVisualStyleBackColor = true;
            this.buttonInfo_ARI.Click += new System.EventHandler(this.buttonInfo_ARI_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(609, 272);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(106, 35);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_ARI_Click);
            // 
            // dataGridViewResult_ARI
            // 
            this.dataGridViewResult_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_ARI.ColumnHeadersVisible = false;
            this.dataGridViewResult_ARI.Location = new System.Drawing.Point(10, 36);
            this.dataGridViewResult_ARI.Name = "dataGridViewResult_ARI";
            this.dataGridViewResult_ARI.RowHeadersVisible = false;
            this.dataGridViewResult_ARI.Size = new System.Drawing.Size(138, 201);
            this.dataGridViewResult_ARI.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 314);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonInfo_ARI);
            this.Controls.Add(this.groupBoxResult_ARI);
            this.Controls.Add(this.groupBoxTask_ARI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 12 | Алеев Р. И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_ARI)).EndInit();
            this.groupBoxResult_ARI.ResumeLayout(false);
            this.groupBoxResult_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ARI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ARI;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.GroupBox groupBoxResult_ARI;
        private System.Windows.Forms.Label labelResult_ARI;
        private System.Windows.Forms.Button buttonInfo_ARI;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewResult_ARI;
    }
}

