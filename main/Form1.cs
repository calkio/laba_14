using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        public static int amount_row = 0;//количество строк массива
        public static int amount_column = 0;//количество столбцов массива

        public static double[,] MyArray = new double[amount_row, amount_column];//массив дабл

        public static Random random = new Random();//рандомное число

        public static int next1 = 0;//минимальный диапозон
        public static int next2 = 0;//максимальный диапазон

        public Form1()
        {
            InitializeComponent();
        }

        private void number_substitution(ref double[,] MyArray,Random random, int next1, int next2)
        {
            int number_between = next2 - next1;

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    MyArray[i, j] = next1 + random.NextDouble() * number_between;
                    Table.Rows[i].Cells[j].Value = String.Format("{0:0.00}", MyArray[i, j]); 
                }
            }   
        }


        /// <summary>
        /// Метод нажатия на кнопку "Создать массив"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Rows.Text.Length > 0 && Columns.Text.Length > 0 && From.Text.Length > 0 && Before.Text.Length > 0)
            {
                amount_row = int.Parse(Rows.Text);
                amount_column = int.Parse(Columns.Text);
                next1 = int.Parse(From.Text);
                next2 = int.Parse(Before.Text);
                MyArray = new double[amount_row, amount_column];

                Table.Rows.Clear();
                Table.Columns.Clear();
                Table.RowHeadersVisible = false;
                Table.ColumnHeadersVisible = false;
                Table.RowCount = amount_row;
                Table.ColumnCount = amount_column;

                number_substitution(ref MyArray, random, next1, next2);
                substitution_TextBox(MyArray);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        MyArray[i, j] = 0;
                        Table.Rows[i].Cells[j].Value = String.Format("{0:0.00}", MyArray[i, j]);
                    }
                }
            }
            substitution_TextBox(MyArray);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    if (i + j == MyArray.GetLength(0) - 1)
                    {
                        MyArray[i, j] = 0;
                        Table.Rows[i].Cells[j].Value = String.Format("{0:0.00}", MyArray[i, j]);
                    }
                }
            }
            substitution_TextBox(MyArray);
        }

        private void substitution_TextBox(double[,] MyArray)
        {
            double sum = 0;
            int index_negative_number = 0;
            int index_positive_number = 0;
            int index_zero = 0;

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    sum += MyArray[i, j];
                    if (MyArray[i,j] > 0)
                    {
                        index_positive_number++;
                    }
                    else if (MyArray[i,j] < 0)
                    {
                        index_negative_number++;
                    }
                    else
                    {
                        index_zero++;
                    }
                }
            }

            TextBox.Text = $"Среднее арефмитическое : {String.Format("{0:0.00}", sum / (MyArray.GetLength(0) + MyArray.GetLength(1)))} \n" +
                            $"Количество положительных чисел : {index_positive_number} \n" +
                            $"Количество отрицательных чисел : {index_negative_number} \n" +
                            $"Количество нулей : {index_zero}";
        }
    }
}
