using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            try
            {
                int sum = 0;
                int[] Array = new int[int.Parse(textBox1.Text)];
                textBox2.Text = "";
                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = i+1;
                    if (((Array[i] % 5 == 2) && (comboBox1.SelectedIndex==0)) || ((Array[i] % 3 == 1) && (comboBox1.SelectedIndex == 1)))
                    {
                        textBox2.Text += Array[i]+" + ";
                        sum += Array[i];
                    }
                }
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 3,3);
                textBox2.Text += " = "+sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("¬ведите число и выберите критерий", "ќшибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}