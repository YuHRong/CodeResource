using System.Windows.Forms;

namespace WinFormApp 
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnOpen_Click(object sender, EventArgs e)
  {
   ListBox listBoxFiles = new ListBox();
   if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
   {
    try
    {
     var path = openFileDialog1.FileName;
     // 将文件按行读取并显示到 ListBox 中
     var lines = System.IO.File.ReadAllLines(path);
     listBoxFiles.Items.Clear();
     listBoxFiles.Items.AddRange(lines);
    }
    catch (System.Exception ex)
    {
     System.Windows.Forms.MessageBox.Show("无法读取文件: " + ex.Message);
    }
   }
  }

  private void btnExit_Click(object sender, EventArgs e)
  {
   Close();
  }
 }
}