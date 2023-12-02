using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AleevRI.Sprint6.Task2.V3.Lib;

namespace Tyuiu.AleevRI.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonInfo_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Алеев Руслан Ильнурович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxVarStart_ARI.Text);
                int StopStep = Convert.ToInt32(textBoxVarStop_ARI.Text);
                int len = ds.GetMassFunction(StartStep, StopStep).Length;
                double[] result = new double[len];
                result = ds.GetMassFunction(StartStep, StopStep);
                this.chartFunction_ARI.Titles.Add("График функции F(X)= sin(x) / x + 1,2 + cos(x) * 7x - 2");

                this.chartFunction_ARI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ARI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_ARI.Rows.Add(Convert.ToString(StartStep), Convert.ToString(result[i]));
                    this.chartFunction_ARI.Series[0].Points.AddXY(StartStep, result[i]);
                    StartStep++;
                }

            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarStart_ARI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxVarStop_ARI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonDone_ARI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ARI.BackColor = Color.Red;
        }

        private void buttonDone_ARI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ARI.BackColor = Color.Green;
        }

        private void buttonDone_ARI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_ARI.BackColor = Color.Blue;
        }
    }
}
