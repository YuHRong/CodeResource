using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  // 播放按钮的单机事件
  private void btn_Playe_Click(object sender, EventArgs e)
  {
   // url的播放地址(string)
   //通过选定的项的值(SelectedItem  返回类型 objcet)
   axWindowsMediaPlayer1.URL = lbox_FileNames.SelectedItem.ToString();

   //播放的方法  (Ctlcontrols属性  包含了：播放、暂停、停止等方法)
   axWindowsMediaPlayer1.Ctlcontrols.play();
   lbl_Name.Text = SubFileName(lbox_FileNames.SelectedItem.ToString());
  }

  //停止按钮的单击事件
  private void btn_Stop_Click(object sender, EventArgs e)
  {
   //停止的方法 (Ctlcontrols属性  包含了：播放、暂停、停止等方法)
   axWindowsMediaPlayer1.Ctlcontrols.stop();
  }

  private void 本地文件ToolStripMenuItem_Click(object sender, EventArgs e)
  {
   //设置或获取文件的目录路径
   ofd_OpenFiles.InitialDirectory = @"F:\KuGou\";

   //设置文件名称
   ofd_OpenFiles.FileName = null;

   //设置文件筛选器
   ofd_OpenFiles.Filter = "媒体文|*.mp3;*.wma;*.wav;*.avi;*.mpg;*.mp4;*.asf;*.mid;*.wmv";

   //设置是否允许选择多个文件
   ofd_OpenFiles.Multiselect = true;

   //判断是否点击了(对话框弹出时)它的打开的按钮
   if (ofd_OpenFiles.ShowDialog() == DialogResult.OK)
   {
    //foreach(接收的数据类型  变量名  in 选择的所有文件的名称[包含了它的全路径  返回类型：string[] ])
    foreach (object obj in ofd_OpenFiles.FileNames)
    {
     //添加到listBox的集合中
     lbox_FileNames.Items.Add(obj);
    }
   }
  }
  private void 本地文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
  {
   //FolderBrowserDialiog控件的默认文件夹路径
   fbd_OpenDicetory.SelectedPath = @"F\KuGou";
   //设置是否显示“新建文件夹”按钮  (false为不显示  true为显示)
   fbd_OpenDicetory.ShowNewFolderButton = false;
   //设置显示提示标题文字
   fbd_OpenDicetory.Description = "请选择媒体文件夹";
   //判断是否点击了确定按钮
   if (fbd_OpenDicetory.ShowDialog() == DialogResult.OK)
   {
    //实例化目录信息的类 (文件夹的全路径)
    DirectoryInfo dir = new DirectoryInfo(fbd_OpenDicetory.SelectedPath);
    //遍历文件夹中所有文件(除子文件夹)
    foreach (FileInfo info in dir.GetFiles())
    {
     //判断文件的后缀名 进行筛选
     if (info.Extension.Equals(".mp3") || info.Extension.Equals(".wmv"))
     {
      //把筛选后的文件添加到ListBox控件的集合中
      lbox_FileNames.Items.Add(info.FullName);
     }
    }
   }
  }
}
