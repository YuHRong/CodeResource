namespace PictureViewer
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void showButton_Click(object sender, EventArgs e)
  {
//显示打开文件对话框，如果用户单机确定，则加载
//用户选择的图片
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    pictureBox1.Load(openFileDialog1.FileName);
   }
  }

  private void clearButton_Click(object sender, EventArgs e)
  {
   //清除图片
   pictureBox1.Image = null;
  }

  private void backgroundButton_Click(object sender, EventArgs e)
  {
   //显示颜色对话框，如果用户单击确定，请更改
   //图片设置为用户选择的颜色
   if (colorDialog1.ShowDialog() == DialogResult.OK)
    pictureBox1.BackColor = colorDialog1.Color;
  }

  private void closeButton_Click(object sender, EventArgs e)
  {
   //关闭列表
   Close();
  }

  private void checkBox1_Click(object sender, EventArgs e)
  {
   //如果用户选择拉伸复选框
   // 更改PictureBox 的尺寸设置为拉伸，如果用户未选择，则设置为正常
   if (checkBox1.Checked)
    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
   else
    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
  }
 }
}
