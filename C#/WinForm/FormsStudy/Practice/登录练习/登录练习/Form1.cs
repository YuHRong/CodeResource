using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录练习
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void button1_Click(object sender, EventArgs e)
  {
   MessageBox.Show("确定");

   string account = textBox1.Text;

   Index index = new Index(textBox1.Text);
   index.Show();

   GlobalFunc._Instance.AccountG = account;
   GlobalFunc._Instance.formLogin.Hide();
  }
 }
}
 