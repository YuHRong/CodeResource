namespace MyMetronome
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
   this.components = new System.ComponentModel.Container();
   this.NumBPM = new System.Windows.Forms.NumericUpDown();
   this.CmbSignature = new System.Windows.Forms.ComboBox();
   this.BtnStartStop = new System.Windows.Forms.Button();
   this.MetronomeTimer = new System.Windows.Forms.Timer(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.NumBPM)).BeginInit();
   this.SuspendLayout();
   // 
   // NumBPM
   // 
   this.NumBPM.Location = new System.Drawing.Point(0, 0);
   this.NumBPM.Maximum = new decimal(new int[] {
            960,
            0,
            0,
            0});
   this.NumBPM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
   this.NumBPM.Name = "NumBPM";
   this.NumBPM.Size = new System.Drawing.Size(120, 21);
   this.NumBPM.TabIndex = 0;
   this.NumBPM.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
   // 
   // CmbSignature
   // 
   this.CmbSignature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.CmbSignature.FormattingEnabled = true;
   this.CmbSignature.Items.AddRange(new object[] {
            "2/4",
            "3/4",
            "4/4",
            "6/8"});
   this.CmbSignature.Location = new System.Drawing.Point(8, 8);
   this.CmbSignature.Name = "CmbSignature";
   this.CmbSignature.Size = new System.Drawing.Size(121, 20);
   this.CmbSignature.TabIndex = 1;
   // 
   // BtnStartStop
   // 
   this.BtnStartStop.Location = new System.Drawing.Point(16, 16);
   this.BtnStartStop.Name = "BtnStartStop";
   this.BtnStartStop.Size = new System.Drawing.Size(75, 23);
   this.BtnStartStop.TabIndex = 2;
   this.BtnStartStop.Text = "开始";
   this.BtnStartStop.UseVisualStyleBackColor = true;
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(800, 450);
   this.Controls.Add(this.BtnStartStop);
   this.Controls.Add(this.CmbSignature);
   this.Controls.Add(this.NumBPM);
   this.Name = "Form1";
   this.Text = "Form1";
   ((System.ComponentModel.ISupportInitialize)(this.NumBPM)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.NumericUpDown NumBPM;
  private System.Windows.Forms.ComboBox CmbSignature;
  private System.Windows.Forms.Button BtnStartStop;
  private System.Windows.Forms.Timer MetronomeTimer;
 }
}

