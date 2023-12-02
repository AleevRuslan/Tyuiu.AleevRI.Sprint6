using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AleevRI.Sprint6.Task3.V12.Lib;

namespace Tyuiu.AleevRI.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { -6, -13, -1, -7, 10 },
                                        { 14, -18, 18, 1, 11 },
                                        { -2, -17, -15, -10, -8 },
                                        { 19, -4, -6, -11, 8 },
                                        { -17, 17, 14, 13, 19 }, };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_ARI.ColumnCount = columns;
            dataGridViewMatrix_ARI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_ARI.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_ARI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_ARI_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewResult_ARI.ColumnCount = columns;
            dataGridViewResult_ARI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_ARI.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_ARI.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonInfo_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Алеев Руслан Ильнурович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
