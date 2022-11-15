using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                textBox1.Text = "";
                for (int i = 1; i < 101; i++)
                {
                    if (((comboBox1.SelectedIndex == 0) && (i % 5 == 2)) || ((comboBox1.SelectedIndex == 1) && (i % 3 == 1)))
                    {
                        textBox1.Text += i + " + ";
                        sum += i;
                    }
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 2, 2);
                textBox1.Text += "= " + sum;
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите критерий", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
