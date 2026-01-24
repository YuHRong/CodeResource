namespace HelloWorld
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
   btnClickThis = new Button();
   lblHelloWorld = new Label();
   SuspendLayout();
   // 
   // btnClickThis
   // 
   btnClickThis.Location = new Point(0, 0);
   btnClickThis.Name = "btnClickThis";
   btnClickThis.Size = new Size(75, 23);
   btnClickThis.TabIndex = 0;
   btnClickThis.Text = "Click this";
   btnClickThis.UseVisualStyleBackColor = true;
   btnClickThis.Click += btnClickThis_Click;
   // 
   // lblHelloWorld
   // 
   lblHelloWorld.AutoSize = true;
   lblHelloWorld.Location = new Point(379, 217);
   lblHelloWorld.Name = "lblHelloWorld";
   lblHelloWorld.Size = new Size(43, 17);
   lblHelloWorld.TabIndex = 2;
   lblHelloWorld.Text = "label1";
   // 
   // Form1
   // 
   AutoScaleDimensions = new SizeF(7F, 17F);
   AutoScaleMode = AutoScaleMode.Font;
   ClientSize = new Size(800, 450);
   Controls.Add(btnClickThis);
   Controls.Add(lblHelloWorld);
   Name = "Form1";
   Text = "Form1";
   ResumeLayout(false);
   PerformLayout();
  }

  #endregion

  private Button btnClickThis;
  private Label lblHelloWorld;
 }
}
