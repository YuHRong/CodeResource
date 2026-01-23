using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();

   this.PreviewKeyDown += Form1_PreviewKeyDown;
  }

//  private void button1_Click(object sender, EventArgs e)
  //{
  //
  //}

  private void button1_Click_1(object sender, EventArgs e)
  {
   DialogResult result = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

   if (result == DialogResult.Yes)
   {
    this.Close();
   }
  }
 
  private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
  {
   if (e.KeyCode == Keys.Escape)
   {
    MessageBox.Show("取消退出");
   }
  }
 }
}
