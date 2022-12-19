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
    public partial class Задание_2 : Form
    {
        public Задание_2()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            int k1, k2;


            k1 = int.Parse(textBox1.Text);
            if (k1 <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }

            k2 = int.Parse(textBox2.Text);

            if (k2 <= 0)
            {
                MessageBox.Show("Введите целое число больше 0");
                return;
            }

            using (StreamReader sr = new StreamReader("C:\\Users\\Пользователь\\Desktop\\Учебная практика (осень) 3 курс\\3 неделя\\9 задание\\zad9.2 form.txt"))
            {
                string line;

                while (true)
                {
                    line = sr.ReadLine(); // считываем из файла весь текст

                       if (line == null) break;

                    for (int i = k1 - 1; i <= k2 - 1; i++)
                        textBox5.Text += line[i];
                    textBox5.Text += Environment.NewLine;
                }
            }
        }
 
            

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox5.Text = "";
            textBox5.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar; if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; MessageBox.Show("Введите целое число");
            }

        }
    }
}
   