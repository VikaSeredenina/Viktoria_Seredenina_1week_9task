using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadania_9
{
    public partial class Задание_1 : Form
    {
        public Задание_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int n = int.Parse(textBox1.Text);
            if (n <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }


            string[] elem = textBox2.Text.Split(' ');
            if (elem.Length != n)
            {
                MessageBox.Show("Длина не соответсвует введенному!");
                return;
            }
          
            double[] mass = new double[n];
           
            for (i = 0; i < n; i++)
            {
               
                mass[i] = double.Parse(elem[i]);
            }

            //Диапазон

            double A = double.Parse(textBox3.Text);
            
            double B = double.Parse(textBox4.Text);
            if (A > B)
            {
                MessageBox.Show ("Начало диапазона не может быть больше конца:");
                return;
            }



            // запись в файл dat
            FileStream f = new FileStream("out form.dat", FileMode.Create);
            BinaryWriter fOut = new BinaryWriter(f);
            for (int j = 0; j < n; j++)
            {
                fOut.Write(mass[j]);
            }

            fOut.Close();

            //запись из dat в txt
            f = new FileStream("out form.dat", FileMode.Open);
            BinaryReader fIn = new BinaryReader(f);
            StreamWriter sw = new StreamWriter(File.Open("out form.txt", FileMode.Create), Encoding.UTF8);


            // считываем каждое значение из файла
            double a;
            while (fIn.PeekChar() > -1)
            {
                a = Math.Round(fIn.ReadDouble(), 2);

                sw.Write(a + " ");
            }


            fIn.Close();
            sw.Close();
            f.Close();

            // запись из файла в консоль
            StreamReader sr = new StreamReader("out form.txt");
            string s = sr.ReadLine();
            sr.Close();
            string[] text = s.Split(' ');
            double[] array = new double[text.Length];
            for (int j = 0; j < array.GetLength(0) - 1; j++)
            {
                array[j] = double.Parse(text[j]);
                if (!(array[j] >= A && array[j] <= B))
                    textBox5.Text += array[j] + " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
            textBox4.Text = "";
            textBox4.Clear();
            textBox5.Text = "";
            textBox5.Clear();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true; MessageBox.Show("Введите число");
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true; MessageBox.Show("Введите число");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true; MessageBox.Show("Введите число");
            }
        }
    }
}


    

