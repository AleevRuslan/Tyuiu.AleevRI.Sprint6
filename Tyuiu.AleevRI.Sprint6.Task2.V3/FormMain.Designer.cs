
namespace Tyuiu.AleevRI.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_ARI = new System.Windows.Forms.GroupBox();
            this.labelFunction_ARI = new System.Windows.Forms.Label();
            this.chartFunction_ARI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_ARI = new System.Windows.Forms.DataGridView();
            this.Column1_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVar_ARI = new System.Windows.Forms.GroupBox();
            this.labelVarStop_ARI = new System.Windows.Forms.Label();
            this.labelVarStart_ARI = new System.Windows.Forms.Label();
            this.textBoxVarStop_ARI = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_ARI = new System.Windows.Forms.TextBox();
            this.buttonInfo_ARI = new System.Windows.Forms.Button();
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.groupBoxTask_ARI.SuspendLayout();
            this.groupBoxResult_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ARI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ARI)).BeginInit();
            this.groupBoxVar_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_ARI
            // 
            this.groupBoxTask_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxTask_ARI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ARI.Name = "groupBoxTask_ARI";
            this.groupBoxTask_ARI.Size = new System.Drawing.Size(514, 241);
            this.groupBoxTask_ARI.TabIndex = 0;
            this.groupBoxTask_ARI.TabStop = false;
            this.groupBoxTask_ARI.Text = "Условие";
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_ARI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.Size = new System.Drawing.Size(490, 216);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.\r\n\r\n";
            // 
            // groupBoxResult_ARI
            // 
            this.groupBoxResult_ARI.Controls.Add(this.labelFunction_ARI);
            this.groupBoxResult_ARI.Controls.Add(this.chartFunction_ARI);
            this.groupBoxResult_ARI.Controls.Add(this.dataGridViewFunction_ARI);
            this.groupBoxResult_ARI.Location = new System.Drawing.Point(532, 12);
            this.groupBoxResult_ARI.Name = "groupBoxResult_ARI";
            this.groupBoxResult_ARI.Size = new System.Drawing.Size(697, 329);
            this.groupBoxResult_ARI.TabIndex = 0;
            this.groupBoxResult_ARI.TabStop = false;
            this.groupBoxResult_ARI.Text = "Вывод данных";
            // 
            // labelFunction_ARI
            // 
            this.labelFunction_ARI.AutoSize = true;
            this.labelFunction_ARI.Location = new System.Drawing.Point(6, 19);
            this.labelFunction_ARI.Name = "labelFunction_ARI";
            this.labelFunction_ARI.Size = new System.Drawing.Size(62, 13);
            this.labelFunction_ARI.TabIndex = 2;
            this.labelFunction_ARI.Text = "Результат:";
            // 
            // chartFunction_ARI
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_ARI.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_ARI.Legends.Add(legend3);
            this.chartFunction_ARI.Location = new System.Drawing.Point(238, 35);
            this.chartFunction_ARI.Name = "chartFunction_ARI";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_ARI.Series.Add(series3);
            this.chartFunction_ARI.Size = new System.Drawing.Size(447, 289);
            this.chartFunction_ARI.TabIndex = 1;
            this.chartFunction_ARI.Text = "chart1";
            // 
            // dataGridViewFunction_ARI
            // 
            this.dataGridViewFunction_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_ARI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_ARI,
            this.Column2_ARI});
            this.dataGridViewFunction_ARI.Location = new System.Drawing.Point(9, 35);
            this.dataGridViewFunction_ARI.Name = "dataGridViewFunction_ARI";
            this.dataGridViewFunction_ARI.RowHeadersVisible = false;
            this.dataGridViewFunction_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFunction_ARI.Size = new System.Drawing.Size(223, 289);
            this.dataGridViewFunction_ARI.TabIndex = 0;
            // 
            // Column1_ARI
            // 
            this.Column1_ARI.HeaderText = "X";
            this.Column1_ARI.Name = "Column1_ARI";
            this.Column1_ARI.Width = 110;
            // 
            // Column2_ARI
            // 
            this.Column2_ARI.HeaderText = "F(X)";
            this.Column2_ARI.Name = "Column2_ARI";
            this.Column2_ARI.Width = 110;
            // 
            // groupBoxVar_ARI
            // 
            this.groupBoxVar_ARI.Controls.Add(this.labelVarStop_ARI);
            this.groupBoxVar_ARI.Controls.Add(this.labelVarStart_ARI);
            this.groupBoxVar_ARI.Controls.Add(this.textBoxVarStop_ARI);
            this.groupBoxVar_ARI.Controls.Add(this.textBoxVarStart_ARI);
            this.groupBoxVar_ARI.Location = new System.Drawing.Point(12, 269);
            this.groupBoxVar_ARI.Name = "groupBoxVar_ARI";
            this.groupBoxVar_ARI.Size = new System.Drawing.Size(255, 67);
            this.groupBoxVar_ARI.TabIndex = 1;
            this.groupBoxVar_ARI.TabStop = false;
            this.groupBoxVar_ARI.Text = "Ввод данных";
            // 
            // labelVarStop_ARI
            // 
            this.labelVarStop_ARI.AutoSize = true;
            this.labelVarStop_ARI.Location = new System.Drawing.Point(110, 16);
            this.labelVarStop_ARI.Name = "labelVarStop_ARI";
            this.labelVarStop_ARI.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_ARI.TabIndex = 1;
            this.labelVarStop_ARI.Text = "Конец шага:";
            // 
            // labelVarStart_ARI
            // 
            this.labelVarStart_ARI.AutoSize = true;
            this.labelVarStart_ARI.Location = new System.Drawing.Point(6, 16);
            this.labelVarStart_ARI.Name = "labelVarStart_ARI";
            this.labelVarStart_ARI.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_ARI.TabIndex = 1;
            this.labelVarStart_ARI.Text = "Старт шага:";
            // 
            // textBoxVarStop_ARI
            // 
            this.textBoxVarStop_ARI.Location = new System.Drawing.Point(112, 32);
            this.textBoxVarStop_ARI.Name = "textBoxVarStop_ARI";
            this.textBoxVarStop_ARI.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStop_ARI.TabIndex = 0;
            this.textBoxVarStop_ARI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStop_ARI_KeyPress);
            // 
            // textBoxVarStart_ARI
            // 
            this.textBoxVarStart_ARI.Location = new System.Drawing.Point(6, 32);
            this.textBoxVarStart_ARI.Name = "textBoxVarStart_ARI";
            this.textBoxVarStart_ARI.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStart_ARI.TabIndex = 0;
            this.textBoxVarStart_ARI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStart_ARI_KeyPress);
            // 
            // buttonInfo_ARI
            // 
            this.buttonInfo_ARI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_ARI.Location = new System.Drawing.Point(273, 269);
            this.buttonInfo_ARI.Name = "buttonInfo_ARI";
            this.buttonInfo_ARI.Size = new System.Drawing.Size(99, 67);
            this.buttonInfo_ARI.TabIndex = 2;
            this.buttonInfo_ARI.Text = "Справка";
            this.buttonInfo_ARI.UseVisualStyleBackColor = false;
            this.buttonInfo_ARI.Click += new System.EventHandler(this.buttonInfo_ARI_Click);
            // 
            // buttonDone_ARI
            // 
            this.buttonDone_ARI.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_ARI.Location = new System.Drawing.Point(378, 264);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(148, 77);
            this.buttonDone_ARI.TabIndex = 3;
            this.buttonDone_ARI.Text = "Выполнить";
            this.buttonDone_ARI.UseVisualStyleBackColor = false;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_ARI_Click);
            this.buttonDone_ARI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_ARI_MouseDown);
            this.buttonDone_ARI.MouseEnter += new System.EventHandler(this.buttonDone_ARI_MouseEnter);
            this.buttonDone_ARI.MouseLeave += new System.EventHandler(this.buttonDone_ARI_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 344);
            this.Controls.Add(this.buttonDone_ARI);
            this.Controls.Add(this.buttonInfo_ARI);
            this.Controls.Add(this.groupBoxVar_ARI);
            this.Controls.Add(this.groupBoxResult_ARI);
            this.Controls.Add(this.groupBoxTask_ARI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Алеев Р. И.";
            this.groupBoxTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.PerformLayout();
            this.groupBoxResult_ARI.ResumeLayout(false);
            this.groupBoxResult_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ARI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ARI)).EndInit();
            this.groupBoxVar_ARI.ResumeLayout(false);
            this.groupBoxVar_ARI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.GroupBox groupBoxResult_ARI;
        private System.Windows.Forms.Label labelFunction_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ARI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_ARI;
        private System.Windows.Forms.GroupBox groupBoxVar_ARI;
        private System.Windows.Forms.Label labelVarStop_ARI;
        private System.Windows.Forms.Label labelVarStart_ARI;
        private System.Windows.Forms.TextBox textBoxVarStop_ARI;
        private System.Windows.Forms.TextBox textBoxVarStart_ARI;
        private System.Windows.Forms.Button buttonInfo_ARI;
        private System.Windows.Forms.Button buttonDone_ARI;
    }
}

