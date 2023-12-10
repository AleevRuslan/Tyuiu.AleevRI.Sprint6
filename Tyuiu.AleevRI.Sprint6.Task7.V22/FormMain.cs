using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Tyuiu.AleevRI.Sprint6.Task7.V22.Lib;

namespace Tyuiu.AleevRI.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_ARI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_ARI.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_ARI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ARI.ShowDialog();
            openFilePath = openFileDialogTask_ARI.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_ARI.ColumnCount = columns;
            dataGridViewInPut_ARI.RowCount = rows;
            dataGridViewOutPut_ARI.ColumnCount = columns;
            dataGridViewOutPut_ARI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_ARI.Columns[i].Width = 30;
                dataGridViewOutPut_ARI.Columns[i].Width = 30;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_ARI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_ARI.Enabled = true;
        }

        private void buttonDone_ARI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_ARI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_ARI.Enabled = true;
        }

        private void buttonSave_ARI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ARI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_ARI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ARI.ShowDialog();

            string path = saveFileDialogMatrix_ARI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_ARI.RowCount;
            int columns = dataGridViewOutPut_ARI.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_ARI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_ARI.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_ARI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_ARI.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_ARI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_ARI.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_ARI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_ARI.ToolTipTitle = "Сохранить файл";
        }

        private void buttonInfo_ARI_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_ARI.ToolTipTitle = "Справка";
        }

        private void buttonInfo_ARI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_ARI.ColumnCount = 50;
            dataGridViewOutPut_ARI.ColumnCount = 50;

            dataGridViewInPut_ARI.RowCount = 50;
            dataGridViewOutPut_ARI.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_ARI.Columns[i].Width = 25;
                dataGridViewOutPut_ARI.Columns[i].Width = 25;
            }
        }
    }
}
