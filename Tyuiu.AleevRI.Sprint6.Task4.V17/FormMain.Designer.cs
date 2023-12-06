
namespace Tyuiu.AleevRI.Sprint6.Task4.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_ARI = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxResult_ARI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ARI = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_ARI = new System.Windows.Forms.GroupBox();
            this.labelStopStep_ARI = new System.Windows.Forms.Label();
            this.labelStartStep_ARI = new System.Windows.Forms.Label();
            this.textBoxStopStep_ARI = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_ARI = new System.Windows.Forms.TextBox();
            this.buttonDone_ARI = new System.Windows.Forms.Button();
            this.buttonSave_ARI = new System.Windows.Forms.Button();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.chartFunction_ARI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMain_ARI = new System.Windows.Forms.Panel();
            this.panelResult_ARI = new System.Windows.Forms.Panel();
            this.panelFunction_ARI = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxResult_ARI.SuspendLayout();
            this.groupBoxInPutData_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ARI)).BeginInit();
            this.panelMain_ARI.SuspendLayout();
            this.panelResult_ARI.SuspendLayout();
            this.panelFunction_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_ARI
            // 
            this.groupBoxTask_ARI.Controls.Add(this.pictureBox1);
            this.groupBoxTask_ARI.Controls.Add(this.textBoxTask_ARI);
            this.groupBoxTask_ARI.Location = new System.Drawing.Point(0, 3);
            this.groupBoxTask_ARI.Name = "groupBoxTask_ARI";
            this.groupBoxTask_ARI.Size = new System.Drawing.Size(431, 111);
            this.groupBoxTask_ARI.TabIndex = 0;
            this.groupBoxTask_ARI.TabStop = false;
            this.groupBoxTask_ARI.Text = "Условие:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 37);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_ARI
            // 
            this.textBoxTask_ARI.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTask_ARI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ARI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ARI.Multiline = true;
            this.textBoxTask_ARI.Name = "textBoxTask_ARI";
            this.textBoxTask_ARI.ReadOnly = true;
            this.textBoxTask_ARI.Size = new System.Drawing.Size(339, 85);
            this.textBoxTask_ARI.TabIndex = 0;
            this.textBoxTask_ARI.Text = "Протабулировать функцию f(x) на заданном диапазоне от -5 до 5.\r\nПостроить график " +
    "функции и сохранить в файл\r\nOutPutFileTask4V17.txt по нажатию кнопки.\r\n";
            // 
            // groupBoxResult_ARI
            // 
            this.groupBoxResult_ARI.Controls.Add(this.textBoxResult_ARI);
            this.groupBoxResult_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_ARI.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_ARI.Name = "groupBoxResult_ARI";
            this.groupBoxResult_ARI.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxResult_ARI.Size = new System.Drawing.Size(285, 373);
            this.groupBoxResult_ARI.TabIndex = 1;
            this.groupBoxResult_ARI.TabStop = false;
            this.groupBoxResult_ARI.Text = "Вывод:";
            // 
            // textBoxResult_ARI
            // 
            this.textBoxResult_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_ARI.Location = new System.Drawing.Point(5, 18);
            this.textBoxResult_ARI.Multiline = true;
            this.textBoxResult_ARI.Name = "textBoxResult_ARI";
            this.textBoxResult_ARI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ARI.Size = new System.Drawing.Size(275, 350);
            this.textBoxResult_ARI.TabIndex = 0;
            // 
            // groupBoxInPutData_ARI
            // 
            this.groupBoxInPutData_ARI.Controls.Add(this.labelStopStep_ARI);
            this.groupBoxInPutData_ARI.Controls.Add(this.labelStartStep_ARI);
            this.groupBoxInPutData_ARI.Controls.Add(this.textBoxStopStep_ARI);
            this.groupBoxInPutData_ARI.Controls.Add(this.textBoxStartStep_ARI);
            this.groupBoxInPutData_ARI.Location = new System.Drawing.Point(437, 3);
            this.groupBoxInPutData_ARI.Name = "groupBoxInPutData_ARI";
            this.groupBoxInPutData_ARI.Size = new System.Drawing.Size(218, 111);
            this.groupBoxInPutData_ARI.TabIndex = 2;
            this.groupBoxInPutData_ARI.TabStop = false;
            this.groupBoxInPutData_ARI.Text = "Ввод данных";
            // 
            // labelStopStep_ARI
            // 
            this.labelStopStep_ARI.AutoSize = true;
            this.labelStopStep_ARI.Location = new System.Drawing.Point(110, 45);
            this.labelStopStep_ARI.Name = "labelStopStep_ARI";
            this.labelStopStep_ARI.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_ARI.TabIndex = 1;
            this.labelStopStep_ARI.Text = "Конец шага:";
            // 
            // labelStartStep_ARI
            // 
            this.labelStartStep_ARI.AutoSize = true;
            this.labelStartStep_ARI.Location = new System.Drawing.Point(6, 45);
            this.labelStartStep_ARI.Name = "labelStartStep_ARI";
            this.labelStartStep_ARI.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_ARI.TabIndex = 1;
            this.labelStartStep_ARI.Text = "Старт шага:";
            // 
            // textBoxStopStep_ARI
            // 
            this.textBoxStopStep_ARI.Location = new System.Drawing.Point(113, 65);
            this.textBoxStopStep_ARI.Name = "textBoxStopStep_ARI";
            this.textBoxStopStep_ARI.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_ARI.TabIndex = 0;
            // 
            // textBoxStartStep_ARI
            // 
            this.textBoxStartStep_ARI.Location = new System.Drawing.Point(6, 65);
            this.textBoxStartStep_ARI.Name = "textBoxStartStep_ARI";
            this.textBoxStartStep_ARI.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_ARI.TabIndex = 0;
            // 
            // buttonDone_ARI
            // 
            this.buttonDone_ARI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_ARI.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_ARI.Location = new System.Drawing.Point(661, 29);
            this.buttonDone_ARI.Name = "buttonDone_ARI";
            this.buttonDone_ARI.Size = new System.Drawing.Size(87, 51);
            this.buttonDone_ARI.TabIndex = 3;
            this.buttonDone_ARI.Text = "Выполнить";
            this.buttonDone_ARI.UseVisualStyleBackColor = false;
            this.buttonDone_ARI.Click += new System.EventHandler(this.buttonDone_ARI_Click);
            // 
            // buttonSave_ARI
            // 
            this.buttonSave_ARI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_ARI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_ARI.Location = new System.Drawing.Point(768, 29);
            this.buttonSave_ARI.Name = "buttonSave_ARI";
            this.buttonSave_ARI.Size = new System.Drawing.Size(99, 51);
            this.buttonSave_ARI.TabIndex = 4;
            this.buttonSave_ARI.Text = "Сохранить";
            this.buttonSave_ARI.UseVisualStyleBackColor = false;
            this.buttonSave_ARI.Click += new System.EventHandler(this.buttonSave_ARI_Click);
            // 
            // buttonHelp_ARI
            // 
            this.buttonHelp_ARI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ARI.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_ARI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_ARI.Location = new System.Drawing.Point(883, 29);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(82, 51);
            this.buttonHelp_ARI.TabIndex = 5;
            this.buttonHelp_ARI.Text = "Справка";
            this.buttonHelp_ARI.UseVisualStyleBackColor = false;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_ARI_Click);
            // 
            // chartFunction_ARI
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_ARI.ChartAreas.Add(chartArea2);
            this.chartFunction_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFunction_ARI.Legends.Add(legend2);
            this.chartFunction_ARI.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_ARI.Name = "chartFunction_ARI";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chartFunction_ARI.Series.Add(series2);
            this.chartFunction_ARI.Size = new System.Drawing.Size(682, 383);
            this.chartFunction_ARI.TabIndex = 6;
            this.chartFunction_ARI.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.Blue;
            title2.Name = "Title1";
            title2.Text = "График функции";
            this.chartFunction_ARI.Titles.Add(title2);
            // 
            // panelMain_ARI
            // 
            this.panelMain_ARI.BackColor = System.Drawing.SystemColors.Window;
            this.panelMain_ARI.Controls.Add(this.buttonDone_ARI);
            this.panelMain_ARI.Controls.Add(this.groupBoxTask_ARI);
            this.panelMain_ARI.Controls.Add(this.buttonHelp_ARI);
            this.panelMain_ARI.Controls.Add(this.groupBoxInPutData_ARI);
            this.panelMain_ARI.Controls.Add(this.buttonSave_ARI);
            this.panelMain_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelMain_ARI.Name = "panelMain_ARI";
            this.panelMain_ARI.Size = new System.Drawing.Size(977, 120);
            this.panelMain_ARI.TabIndex = 7;
            // 
            // panelResult_ARI
            // 
            this.panelResult_ARI.BackColor = System.Drawing.SystemColors.Window;
            this.panelResult_ARI.Controls.Add(this.groupBoxResult_ARI);
            this.panelResult_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_ARI.Location = new System.Drawing.Point(0, 120);
            this.panelResult_ARI.Name = "panelResult_ARI";
            this.panelResult_ARI.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_ARI.Size = new System.Drawing.Size(295, 383);
            this.panelResult_ARI.TabIndex = 8;
            // 
            // panelFunction_ARI
            // 
            this.panelFunction_ARI.BackColor = System.Drawing.SystemColors.Window;
            this.panelFunction_ARI.Controls.Add(this.splitter1);
            this.panelFunction_ARI.Controls.Add(this.chartFunction_ARI);
            this.panelFunction_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_ARI.Location = new System.Drawing.Point(295, 120);
            this.panelFunction_ARI.Name = "panelFunction_ARI";
            this.panelFunction_ARI.Size = new System.Drawing.Size(682, 383);
            this.panelFunction_ARI.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 383);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 503);
            this.Controls.Add(this.panelFunction_ARI);
            this.Controls.Add(this.panelResult_ARI);
            this.Controls.Add(this.panelMain_ARI);
            this.MinimumSize = new System.Drawing.Size(993, 542);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 14 | Алеев Руслан Ильнурович";
            this.groupBoxTask_ARI.ResumeLayout(false);
            this.groupBoxTask_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxResult_ARI.ResumeLayout(false);
            this.groupBoxResult_ARI.PerformLayout();
            this.groupBoxInPutData_ARI.ResumeLayout(false);
            this.groupBoxInPutData_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ARI)).EndInit();
            this.panelMain_ARI.ResumeLayout(false);
            this.panelResult_ARI.ResumeLayout(false);
            this.panelFunction_ARI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ARI;
        private System.Windows.Forms.TextBox textBoxTask_ARI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxResult_ARI;
        private System.Windows.Forms.TextBox textBoxResult_ARI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_ARI;
        private System.Windows.Forms.Label labelStartStep_ARI;
        private System.Windows.Forms.TextBox textBoxStopStep_ARI;
        private System.Windows.Forms.TextBox textBoxStartStep_ARI;
        private System.Windows.Forms.Label labelStopStep_ARI;
        private System.Windows.Forms.Button buttonDone_ARI;
        private System.Windows.Forms.Button buttonSave_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ARI;
        private System.Windows.Forms.Panel panelMain_ARI;
        private System.Windows.Forms.Panel panelResult_ARI;
        private System.Windows.Forms.Panel panelFunction_ARI;
        private System.Windows.Forms.Splitter splitter1;
    }
}

