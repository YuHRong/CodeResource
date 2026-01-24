using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyWinform;

namespace _1
{
 public partial class Index : Form
 {

  public Index(string account)
   {
   InitializeComponent();
   label1.Text = GlobalFunc._Instance.Name;
  }

  private void Index_FormClosing(object sender, FormClosingEventArgs e)
  {
   Application.Exit();
  }

  private void Index_Load(object sender, EventArgs e)
  {
  }

  private void button1_Click(object sender, EventArgs e)
  {
   string danjia = textBox1.Text;
   string shuliang = textBox2.Text;
   int price = 0;
   int count = 0;
   try
   {
    price = int.Parse(danjia);
    count = int.Parse(shuliang);
   }
   catch
   {
    MessageBox.Show("单价和数量必须为数字");
    return;
   }

   int zoungjia = price * count;
   label4.Text = "总价" + zoungjia.ToString();
  }

  private void button2_Click(object sender, EventArgs e)
  {
    Close();
  }
 }
}
