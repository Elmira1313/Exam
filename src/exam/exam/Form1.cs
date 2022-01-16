
using System;
using System.Windows.Forms;

namespace exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool flag = false;
        int i = 0;
        double x, y;

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Зеничева Э.С.\nстудентка гр ПКсп-119\nВариант 1");
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void f1(double x, double y)
        {
            if (Math.Round(Math.Pow(y, 2) + Math.Pow(x, 2), 2) >= 4 && x >= -2 && y <= -x && y >= 0)
            {
                if (Math.Round(Math.Pow(y, 2) + Math.Pow(x, 2), 2) == 4 && x == -2 && y == -x)
                {
                    MessageBox.Show("Точка находится на границе фигуры");
                    toolStripStatusLabel1.Text = "Точка находится на границе фигуры";
                }
                else
                {
                    MessageBox.Show("Точка находится внутри фигуры");
                    toolStripStatusLabel1.Text = "Точка находится внутри фигуры";
                }
            }
            else
            {
                MessageBox.Show("Точка находится вне фигуры");
                toolStripStatusLabel1.Text = "Точка находится вне фигуры";
            }
        }
        void f2(double x, double y)
        {
            if (Math.Abs(x) <= 1 && Math.Abs(y) <= 1 && Math.Abs(y) <= 1 - Math.Abs(x))
            {
                if (Math.Abs(y) == 1 - Math.Abs(x))
                {
                    MessageBox.Show("Точка находится на границе фигуры");
                    toolStripStatusLabel1.Text = "Точка находится на границе фигуры";
                }
                else
                {
                    MessageBox.Show("Точка находится внутри фигуры");
                    toolStripStatusLabel1.Text = "Точка находится внутри фигуры";
                }
            }
            else
            {
                MessageBox.Show("Точка находится вне фигуры");
                toolStripStatusLabel1.Text = "Точка находится вне фигуры";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if(Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
                {
                    f1(x, y);
                }
                else MessageBox.Show("Неверные данные");
            }
            else if (i == 2)
            {
                if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
                {
                    f2(x, y);
                }
                else MessageBox.Show("Неверные данные");
            }
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TextFiles(*.html)|*.html|AllFiles(*.*)|*.*";
            openFileDialog.ShowDialog();
            
            string[] repSplit = openFileDialog.FileName.Split('\\');
            string strName = repSplit[repSplit.Length - 1];
            if (strName == "var1.html")
            {
                webBrowser1.Navigate(openFileDialog.FileName);
                i = 1;
            }
            else if (strName == "var2.html")
            {
                webBrowser1.Navigate(openFileDialog.FileName);
                i = 2;
            }

            else
            {
                MessageBox.Show($"Нужны файлы var1.html и var2.html");
            }
            if (!flag)
            {
                this.Height += 100;
                flag = true;
            }
        }
    }
}
