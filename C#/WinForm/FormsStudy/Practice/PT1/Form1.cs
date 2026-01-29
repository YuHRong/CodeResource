using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace PT1
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }

  private void btnOpen_Click(object sender, EventArgs e)
  {
   openFileDialog1.Multiselect = true;
   openFileDialog1.Title = "请选择文件";
   openFileDialog1.Filter = "所有文件(*.*)|*.*";
   if (openFileDialog1.ShowDialog() == DialogResult.OK)
   {
    listBox1.Items.Clear();
    listBox1.Items.Add(openFileDialog1);
    //listView1.Items.Clear();
    //listView1.View = View.List;

    //foreach(string fileName in openFileDialog1.FileNames)
    //{
     //listView1.Items.Add(Path.GetFileName(fileName));
    //}
   }
  }

  private void btnPlay_Click(object sender, EventArgs e)
  {
   //SoundPlayer player = new SoundPlayer();
   //SoundPlayer.ReferenceEquals() = File;
  }
 }
}
