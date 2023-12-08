
namespace Tyuiu.AleevRI.Sprint6.Task5.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_ARI = new System.Windows.Forms.Panel();
            this.panelResult_ARI = new System.Windows.Forms.Panel();
            this.panelGraphic_ARI = new System.Windows.Forms.Panel();
            this.groupBoxDataOut_ARI = new System.Windows.Forms.GroupBox();
            this.dataGridViewDataOut_ARI = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ARI = new System.Windows.Forms.Button();
            this.buttonInfo_ARI = new System.Windows.Forms.Button();
            this.chartData_ARI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTask_ARI.SuspendLayout();
            this.panelResult_ARI.SuspendLayout();
            this.panelGraphic_ARI.SuspendLayout();
            this.groupBoxDataOut_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataOut_ARI)).BeginInit();
            this.groupBoxTask_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_ARI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_ARI
            // 
            this.panelTask_ARI.BackColor = System.Drawing.SystemColors.Window;
            this.panelTask_ARI.Controls.Add(this.buttonOpenFile_ARI);
            this.panelTask_ARI.Controls.Add(this.buttonInfo_ARI);
            this.panelTask_ARI.Controls.Add(this.buttonDone_ARI);
            this.panelTask_ARI.Controls.Add(this.groupBoxTask_ARI);
            this.panelTask_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelTask_ARI.Name = "panelTask_ARI";
            this.panelTask_ARI.Size = new System.Drawing.Size(784, 100);
            this.panelTask_ARI.TabIndex = 0;
            // 
            // panelResult_ARI
            // 
            this.panelResult_ARI.Controls.Add(this.groupBoxDataOut_ARI);
            this.panelResult_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_ARI.Location = new System.Drawing.Point(0, 100);
            this.panelResult_ARI.Name = "panelResult_ARI";
            this.panelResult_ARI.Size = new System.Drawing.Size(200, 341);
            this.panelResult_ARI.TabIndex = 1;
            // 
            // panelGraphic_ARI
            // 
            this.panelGraphic_ARI.BackColor = System.Drawing.SystemColors.Window;
            this.panelGraphic_ARI.Controls.Add(this.splitter1);
            this.panelGraphic_ARI.Controls.Add(this.chartData_ARI);
            this.panelGraphic_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphic_ARI.Location = new System.Drawing.Point(200, 100);
            this.panelGraphic_ARI.Name = "panelGraphic_ARI";
            this.panelGraphic_ARI.Size = new System.Drawing.Size(584, 341);
            this.panelGraphic_ARI.TabIndex = 2;
            // 
            // groupBoxDataOut_ARI
            // 
            this.groupBoxDataOut_ARI.Controls.Add(this.dataGridViewDataOut_ARI);
            this.groupBoxDataOut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDataOut_ARI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDataOut_ARI.Name = "groupBoxDataOut_ARI";
            this.groupBoxDataOut_ARI.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxDataOut_ARI.Size = new System.Drawing.Size(200, 341);
            this.groupBoxDataOut_ARI.TabIndex = 0;
            this.groupBoxDataOut_ARI.TabStop = false;
            this.groupBoxDataOut_ARI.Text = "Вывод данных:";
            // 
            // dataGridViewDataOut_ARI
            // 
            this.dataGridViewDataOut_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataOut_ARI.ColumnHeadersVisible = false;
            this.dataGridViewDataOut_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDataOut_ARI.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewDataOut_ARI.Name = "dataGridViewDataOut_ARI";
            this.dataGridViewDataOut_ARI.RowHeadersVisible = false;
            this.dataGridViewDataOut_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDataOut_ARI.Size = new System.Drawing.Size(190, 318);
            this.dataGridViewDataOut_ARI.TabIndex = 0;
            // 
            // groupBoxTask_ARI
            // 
            this.groupBoxTask_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxTask_ARI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ARI.Name = "groupBoxTask_ARI";
            this.groupBoxTask_ARI.Size = new System.Drawing.Size(409, 100);
            this.groupBoxTask_ARI.TabIndex = 0;
            this.groupBoxTask_ARI.TabStop = false;
            this.groupBoxTask_ARI.Text = "Условие";
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.ReadOnly = true;
            this.textBoxTask_ARI.Size = new System.Drawing.Size(403, 81);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = "Прочитать данные из файла InPutFileTask5V24.txt. \r\nВывести в dataGridView.Дан спи" +
    "сок из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значен" +
    "иям.";
            // 
            // buttonDone_ARI
            // 
            this.buttonDone_ARI.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_ARI.Location = new System.Drawing.Point(429, 34);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(81, 43);
            this.buttonDone_ARI.TabIndex = 1;
            this.buttonDone_ARI.Text = "Выполнить";
            this.buttonDone_ARI.UseVisualStyleBackColor = false;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_ARI_Click);
            // 
            // buttonOpenFile_ARI
            // 
            this.buttonOpenFile_ARI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_ARI.Location = new System.Drawing.Point(547, 34);
            this.buttonOpenFile_ARI.Name = "buttonOpenFile_ARI";
            this.buttonOpenFile_ARI.Size = new System.Drawing.Size(86, 43);
            this.buttonOpenFile_ARI.TabIndex = 2;
            this.buttonOpenFile_ARI.Text = "Открыть файл";
            this.buttonOpenFile_ARI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_ARI.Click += new System.EventHandler(this.buttonOpenFile_ARI_Click);
            // 
            // buttonInfo_ARI
            // 
            this.buttonInfo_ARI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_ARI.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_ARI.Location = new System.Drawing.Point(669, 34);
            this.buttonInfo_ARI.Name = "buttonInfo_ARI";
            this.buttonInfo_ARI.Size = new System.Drawing.Size(75, 43);
            this.buttonInfo_ARI.TabIndex = 1;
            this.buttonInfo_ARI.Text = "Справка";
            this.buttonInfo_ARI.UseVisualStyleBackColor = false;
            this.buttonInfo_ARI.Click += new System.EventHandler(this.buttonInfo_ARI_Click);
            // 
            // chartData_ARI
            // 
            chartArea5.Name = "ChartArea1";
            this.chartData_ARI.ChartAreas.Add(chartArea5);
            this.chartData_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartData_ARI.Legends.Add(legend5);
            this.chartData_ARI.Location = new System.Drawing.Point(0, 0);
            this.chartData_ARI.Name = "chartData_ARI";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.LimeGreen;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 2;
            this.chartData_ARI.Series.Add(series5);
            this.chartData_ARI.Size = new System.Drawing.Size(584, 341);
            this.chartData_ARI.TabIndex = 1;
            this.chartData_ARI.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 341);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panelGraphic_ARI);
            this.Controls.Add(this.panelResult_ARI);
            this.Controls.Add(this.panelTask_ARI);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 24 | Алеев Р. И.";
            this.panelTask_ARI.ResumeLayout(false);
            this.panelResult_ARI.ResumeLayout(false);
            this.panelGraphic_ARI.ResumeLayout(false);
            this.groupBoxDataOut_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataOut_ARI)).EndInit();
            this.groupBoxTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData_ARI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_ARI;
        private System.Windows.Forms.Panel panelResult_ARI;
        private System.Windows.Forms.Panel panelGraphic_ARI;
        private System.Windows.Forms.Button buttonOpenFile_ARI;
        private System.Windows.Forms.Button buttonInfo_ARI;
        private System.Windows.Forms.Button buttonDone_ARI;
        private System.Windows.Forms.GroupBox groupBoxTask_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.GroupBox groupBoxDataOut_ARI;
        private System.Windows.Forms.DataGridView dataGridViewDataOut_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_ARI;
        private System.Windows.Forms.Splitter splitter1;
    }
}

