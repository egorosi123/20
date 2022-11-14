using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b;
            try
            {
                while (true)
                {
                    b = int.Parse(Interaction.InputBox("Введите число для суммирования:", "Сумма"));
                    a += b;
                    if (b == 0) break;
                }
                MessageBox.Show("Сумма чисел: " + a);
            }
            catch
            {
                MessageBox.Show("Ошибка. Попробуйте снова", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
