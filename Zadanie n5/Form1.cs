using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_n5
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; //Указываем количество строк
            dataGridView1.ColumnCount = 15; //Указываем количество столбцов
            double[,] A = new double[15, 15]; //Инициализируем массив
            int i, j;
            double[][] help = new double[16][];
            for (i = 0; i < 16; i++)
            {
                    help[i] = new double[16];
            }
            void func(int a, int b, double c)
            {
                
                dataGridView2.Rows[a].Cells[b].Value = Convert.ToString(help[a][b]);
            }
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    A[i, j] = rand.Next(1, 100);
            //Выводим матрицу в dataGridView1
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);

            //dataGridView2
            double text =Convert.ToDouble(textBox1.Text)
                ;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    if (A[i, j] % text == 0)
                    {
                        double S = A[i, j];
                        func(i, j, S);
                    }
                    else
                    {
                        func(i, j, 0.1);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
