public class LoginDialg : Form
{
 Button OkButton;
 Button CancelButton;

 public LoginDialg()
 {
  OkButton = new Button(...);
  OkButton.Click += new EventHandler(OkButtonClick);

  CancelButton = new Button(...);
  CancelButton.Click += new EventHandler(CancelButtonClick);
 }

 void OkButtonClick(object sender, EventArgs e)
 {
  // 处理 OkButton.Click 事件
 }

 void CancelButtonClick(object sender, EventArgs e)
 {
  // 处理 CancelButton.Click 事件
 }
}