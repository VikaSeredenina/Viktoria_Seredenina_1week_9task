using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Задание_1 one = new Задание_1();
            one.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Задание_2 two = new Задание_2();
            two.Show();
        }
    }
}
