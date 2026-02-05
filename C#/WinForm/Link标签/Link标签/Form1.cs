using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Link标签
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
   SetListView();
  }

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
   try
   {
    VisitLink();
   }
   catch (Exception ex)
   {
    MessageBox.Show("Unable to open link that was clicked.");
   }
  }

  private void VisitLink()
  {
   // Change the color of the link text by setting LinkVisited
   // to true.
   linkLabel1.LinkVisited = true;
   //Call the Process.Start method to open the default browser
   //with a URL:
   System.Diagnostics.Process.Start("http://www.zd.hk");
  }

  private void listView1_Click(object sender, EventArgs e)
  {

  }
 }
}
