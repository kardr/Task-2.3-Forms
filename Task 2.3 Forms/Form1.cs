using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2._3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 100;

            while (i < 1000)
            {
                int a = i / 100;
                int b = (i % 100) / 10;
                int c = i % 10;
                if ((a == b) || (a == c) || (b == c))
                    textBox1.Text += i + " ";
                i++;
            }

            i = 100;
            do
            {
                int a = i / 100;
                int b = (i % 100) / 10;
                int c = i % 10;
                if ((a == b) || (a == c) || (b == c))
                    textBox2.Text += i + " ";
                i++;
            }
            while (i < 1000);

            for (i = 100; i < 1000; i++)
            {
                int a = i / 100;
                int b = (i % 100) / 10;
                int c = i % 10;
                if ((a == b) || (a == c) || (b == c))
                    textBox3.Text += i + " ";
            }
        }
    }
}
