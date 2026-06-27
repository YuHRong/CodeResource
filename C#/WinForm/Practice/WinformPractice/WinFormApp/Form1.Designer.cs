namespace WinFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

  #region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   lblMessage = new Label();
   openFileDialog1 = new OpenFileDialog();
   btnOpen = new Button();
   btnExit = new Button();
   listBox = new ListBox();
   SuspendLayout();
   // 
   // lblMessage
   // 
   lblMessage.AutoSize = true;
   lblMessage.Location = new Point(0, 1);
   lblMessage.Name = "lblMessage";
   lblMessage.Size = new Size(75, 17);
   lblMessage.TabIndex = 0;
   lblMessage.Text = "Hello world";
   // 
   // openFileDialog1
   // 
   openFileDialog1.FileName = "openFileDialog1";
   // 
   // btnOpen
   // 
   btnOpen.Location = new Point(0, 0);
   btnOpen.Name = "btnOpen";
   btnOpen.Size = new Size(75, 23);
   btnOpen.TabIndex = 2;
   btnOpen.Text = "打开文件";
   btnOpen.UseVisualStyleBackColor = true;
   btnOpen.Click += btnOpen_Click;
   // 
   // btnExit
   // 
   btnExit.Location = new Point(8, 9);
   btnExit.Name = "btnExit";
   btnExit.Size = new Size(75, 23);
   btnExit.TabIndex = 3;
   btnExit.Text = "退出";
   btnExit.UseVisualStyleBackColor = true;
   btnExit.Click += btnExit_Click;
   // 
   // listBox
   // 
   listBox.FormattingEnabled = true;
   listBox.ItemHeight = 17;
   listBox.Location = new Point(0, 0);
   listBox.Name = "listBox";
   listBox.Size = new Size(120, 89);
   listBox.TabIndex = 4;
   // 
   // Form1
   // 
   AutoScaleDimensions = new SizeF(7F, 17F);
   AutoScaleMode = AutoScaleMode.Font;
   ClientSize = new Size(800, 450);
   Controls.Add(listBox);
   Controls.Add(btnExit);
   Controls.Add(btnOpen);
   Controls.Add(lblMessage);
   Name = "Form1";
   Text = "Form1";
   ResumeLayout(false);
   PerformLayout();
  }

  #endregion

  private Label lblMessage;
  private OpenFileDialog openFileDialog1;
  private Button btnOpen;
  private Button btnExit;
  private ListBox listBox;
 }
}
