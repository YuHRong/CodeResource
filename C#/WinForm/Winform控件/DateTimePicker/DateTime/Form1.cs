using System;
using System.Windows.Forms;

namespace DateTime
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();

   //dateTimePicker1.Format = DateTimePickerFormat.Custom;
   // 将日期显示为“xxxx年 xx月 xx日 星期x”。
   //dateTimePicker1.CustomFormat = "'今天是'yyyy年 MM月 dd日 ddd";


   //MessageBox.Show("所选格式为" + dateTimePicker1.Text);

   MessageBox.Show(dateTimePicker1.Value.Year + "年");
   MessageBox.Show(dateTimePicker1.Value.Month + "月");
   MessageBox.Show(dateTimePicker1.Value.Day + "日");
   MessageBox.Show(dateTimePicker1.Value.DayOfWeek.ToString());

   MessageBox.Show(dateTimePicker1.Value.Hour + "点");
   MessageBox.Show(dateTimePicker1.Value.Minute + "分");
   MessageBox.Show(dateTimePicker1.Value.Second + "秒");
   MessageBox.Show(dateTimePicker1.Value.Millisecond + "毫秒");
  }

  private DateTimePicker timePicker;

  private void InitializeTimePacker()
  {
   timePicker = new DateTimePicker();
   timePicker.Format = DateTimePickerFormat.Time;
   timePicker.ShowUpDown = true;
   timePicker.Location = new System.Drawing.Point(10, 10);
   timePicker.Width = 100;
   Controls.Add(timePicker);
  }
 }
}
