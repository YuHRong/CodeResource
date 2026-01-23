using System;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Button1Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int amount))
            {
                MessageBox.Show("你输入了：" + amount);
            }
            else
            {
                MessageBox.Show("请输入数字！");
            }
        }
        private void Button2Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}