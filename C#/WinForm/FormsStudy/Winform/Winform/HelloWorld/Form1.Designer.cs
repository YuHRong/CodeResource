namespace HelloWorld
{
 partial class Form1
 {
  /// <summary>
  /// 必需的设计器变量。
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// 清理所有正在使用的资源。
  /// </summary>
  /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows 窗体设计器生成的代码

  /// <summary>
  /// 设计器支持所需的方法 - 不要修改
  /// 使用代码编辑器修改此方法的内容。
  /// </summary>
  private void InitializeComponent()
  {
   this.btnClickThis = new System.Windows.Forms.Button();
   this.lblHelloWorld = new System.Windows.Forms.Label();
   this.SuspendLayout();
   // 
   // btnClickThis
   // 
   this.btnClickThis.Location = new System.Drawing.Point(0, 0);
   this.btnClickThis.Name = "btnClickThis";
   this.btnClickThis.Size = new System.Drawing.Size(75, 23);
   this.btnClickThis.TabIndex = 0;
   this.btnClickThis.Text = "Click this";
   this.btnClickThis.UseVisualStyleBackColor = true;
   this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
   // 
   // lblHelloWorld
   // 
   this.lblHelloWorld.AutoSize = true;
   this.lblHelloWorld.Location = new System.Drawing.Point(8, 7);
   this.lblHelloWorld.Name = "lblHelloWorld";
   this.lblHelloWorld.Size = new System.Drawing.Size(41, 12);
   this.lblHelloWorld.TabIndex = 1;
   this.lblHelloWorld.Text = "label1";
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.lblHelloWorld);
   this.Controls.Add(this.btnClickThis);
   this.Name = "Form1";
   this.Text = "..";
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Button btnClickThis;
  private System.Windows.Forms.Label lblHelloWorld;
 }
}

