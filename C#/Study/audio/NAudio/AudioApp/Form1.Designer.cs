namespace AudioApp
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
   this.OnButtonPlay = new System.Windows.Forms.Button();
   this.OnButtonStop = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // OnButtonPlay
   // 
   this.OnButtonPlay.Location = new System.Drawing.Point(0, 2);
   this.OnButtonPlay.Name = "OnButtonPlay";
   this.OnButtonPlay.Size = new System.Drawing.Size(75, 23);
   this.OnButtonPlay.TabIndex = 0;
   this.OnButtonPlay.Text = "buttonPlay";
   this.OnButtonPlay.UseVisualStyleBackColor = true;
   this.OnButtonPlay.Click += new System.EventHandler(this.OnButtonPlay_Click);
   // 
   // OnButtonStop
   // 
   this.OnButtonStop.Location = new System.Drawing.Point(8, 8);
   this.OnButtonStop.Name = "OnButtonStop";
   this.OnButtonStop.Size = new System.Drawing.Size(75, 23);
   this.OnButtonStop.TabIndex = 1;
   this.OnButtonStop.Text = "buttonStop";
   this.OnButtonStop.UseVisualStyleBackColor = true;
   this.OnButtonStop.Click += new System.EventHandler(this.OnButtonStop_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.OnButtonStop);
   this.Controls.Add(this.OnButtonPlay);
   this.Name = "Form1";
   this.Text = "Form1";
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button OnButtonPlay;
  private System.Windows.Forms.Button OnButtonStop;
 }
}

