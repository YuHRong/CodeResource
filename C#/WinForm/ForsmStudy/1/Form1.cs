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
using StudyWinform;

namespace _1
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }


  private void button1_Click_1(object sender, EventArgs e)
  {
   // 验证账号密码
   // 检查账号
   if (textBox1.Text == "")
   {
    MessageBox.Show("请输入账号");
    return;
   }
   // 检查密码
   if (textBox2.Text == "")
   {
    MessageBox.Show("请输入密码");
    return;
   }
   //验证账号密码是否正确
   if (textBox1.Text != "123")
   {
    MessageBox.Show("账号输入错误");
    textBox1.Text = "";
    return;
   }
   if (textBox2.Text != "456")
   {
    MessageBox.Show("您的密码输入错误");
    textBox2.Text = "";
    return;
   }
   // 如果账号和密码都正确，显示成功消息
   //MessageBox.Show("验证成功，请登录");

   string account = textBox1.Text;

      Index index = new Index(textBox1.Text);
   index.Show();

      //this.Hide();

   GlobalFunc._Instance.AccountG = account;
   GlobalFunc._Instance.formLogin.Hide();
  }
 }
}
