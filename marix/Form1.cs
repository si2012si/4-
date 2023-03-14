using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace marix
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sb.Append(matrix[i, j] + "\t");
                }
                sb.AppendLine();
            }
            richTextBox1.Text = sb.ToString();
            int[,] arr = matrix;
            int min = arr[0, 0];
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            mintext.Text = "Minimum element of the matrix: " + min;
            mintext.Text = mintext.Text + " Maximum element of the matrix: " + max;
        }
        private void SumColumnsButton_Click(object sender, EventArgs e)
        {
            // суммы по столбцам матрицы
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
               
                MessageBox.Show($"Sum of column {i} is {sum}");
                sum = 0;
            }
        }
        private void SumRowsButton_Click(object sender, EventArgs e)
        {
            // суммы по строкам матрицы
            for (int i = 0; i < 3; i++)
            {
                int rowSums=0;
                for (int j = 0; j < 3; j++)
                {
                    rowSums += matrix[i, j];
                }
                MessageBox.Show($"Sum of column {i} is {rowSums.ToString()}");
               
            }
        }
        private void MinElementButton_Click(object sender, EventArgs e)
        {
            // наименьший элемент матрицы
        }
        private void MaxElementButton_Click(object sender, EventArgs e)
        {
            // наибольший элемент матрицы
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // выход
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/777/source/repos/4 курс/ConsoleApp1/bin/Debug/net5.0/ConsoleApp1.exe");
            this.Close();
            System.Diagnostics.Process.Start("C:/Users/777/source/repos/4 курс/ConsoleApp2/bin/Debug/net5.0/ConsoleApp2.exe");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            
            System.Diagnostics.Process.Start("C:/Users/777/source/repos/4 курс/ConsoleApp3/bin/Debug/net5.0/ConsoleApp3.exe");
            System.Diagnostics.Process.Start("C:/Users/777/source/repos/4 курс/ConsoleApp4/bin/Debug/net5.0/ConsoleApp4.exe");
         //   System.Diagnostics.Process.Start("C:/Users/777/source/repos/4 курс/ConsoleApp5/bin/Debug/net5.0/ConsoleApp5.exe");
       
        }
    }
}

