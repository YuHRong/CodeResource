using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打开文件
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btn1_Click(object sender, EventArgs e)
  {
   OpenFileDialog dialog = new OpenFileDialog();
   dialog.Multiselect = true;      // 确定可以多选文件
   dialog.Title = "请选择文件夹";
   dialog.Filter = "所有文件(*.*)|*.*";
   if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
   {
    string file = dialog.FileName;
   }
  }

  private void Ctrl(object sender, KeyEventArgs e)
  {

  }
 }
}
