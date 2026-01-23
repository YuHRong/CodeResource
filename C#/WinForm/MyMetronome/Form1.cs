using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetronome
{
 public partial class Form1 : Form
 {
  // ================= 全局变量区 =================

  // 1. 声音播放器
  // SoundPlayer 是 System.Media 命名空间下的类，专门用来播放简单的 .wav 文件
  private SoundPlayer playerStrong;
  private SoundPlayer playerWeak;

  // 2. 逻辑控制变量
  private int currentBeat = 0;  // 当前到地几拍
  private int beatsPerMeasure = 4;  // 一小节里面有几拍，默认4
  private bool isRunning = false;  // 记录节拍器是否正在运行

  // ================= 构造函数 =================
  public Form1()
  {
   InitializeComponent();

   // 初始化自定义设置
   InitializeMetronome();

   // 添加这一行：设置窗体可以接收键盘事件
   this.KeyPreview = true;
  }

  // 添加键盘按下事件处理
  protected override void OnKeyDown(KeyEventArgs e)
  {
   base.OnKeyDown(e);

   if (e.KeyCode == Keys.Space)
   {
    // 切换开始/停止状态
    if (isRunning)
    {
     StopMetronome();
    }
    else
    {
     StartMetronome();
    }
    e.Handled = true;
   }
  }

  // 这是一个自定义方法，用来做准备工作，保持代码整洁
  private async Task InitializeMetronome()
  {
   // 1. 加载音频资源
   // Properties.Resources.strong 关联的是你刚才嵌入的资源
   // 我们把这个资源流(Stream)交给 SoundPlayer
   playerStrong = new SoundPlayer(Properties.Resources.strong);
   playerWeak = new SoundPlayer(Properties.Resources.weak);

   // 预加载声音，防止第一次播放卡顿
   // 异步预加载，不阻塞界面
   /*
   await Task.Run(() =>
   {
      playerStrong.Load();
   playerWeak.Load();
   });
*/

   // 2. 设置默认的节拍类型
   CmbSignature.SelectedIndex = 2;  //默认选中第三项

   // 3. 关联计时器事件
   // 意思就是：每当时间到了，就去执行 metronomeTimer_Tick 这个方法
   // metronomeTimer 是你在设计器里加的那个 Timer 控件
   MetronomeTimer.Tick += MetronomeTimer_Tick;

   // 添加这一行：绑定按钮点击事件
   BtnStartStop.Click += BtnStartStop_Click;
  }

  // ================= 事件处理区 =================

  // 按钮点击事件：处理 开始/停止
  private void BtnStartStop_Click(object sender, EventArgs e)
  {
   if (isRunning)
   {
    // 如果正在跑，就停下来
    StopMetronome();
   }
   else
   {
    // 如果没跑，就根据当前设置开始跑
    StartMetronome();
   }
  }

  // 真正的开始逻辑
  private void StartMetronome()
  {
   // 1. 获取用户设定的 BPM
   // numBpm.Value 是 decimal 类型，我们要转成 int
   int bpm = (int)NumBPM.Value;


   // 2. 计算间隔时间 (毫秒)
   // 公式：60秒(60000毫秒) / BPM = 每一拍的间隔
   // 例如 60 BPM -> 60000 / 60 = 1000毫秒 (1秒响一次)
   if (bpm > 0)
   {
    MetronomeTimer.Interval = 60000 / bpm;
   }

   // 3. 解析节拍类型 (例如 "4/4" 还是 "3/4")
   ParseTimeSignature();

   // 4. 重置拍数，准备从第1拍开始
   currentBeat = 0;

   // 5. 启动计时器
   MetronomeTimer.Start();

   // 6. 更新界面状态
   isRunning = true;
   BtnStartStop.Text = "停止"; // 按钮文字变成停止

   // 为了更好的体验，开始时立刻让输入框不可用，防止运行时乱改出bug
   NumBPM.Enabled = false;
   CmbSignature.Enabled = false;
  }

  // 真正的停止逻辑
  private void StopMetronome()
  {
   MetronomeTimer.Stop();
   isRunning = false;
   BtnStartStop.Text = "开始";

   // 恢复控件可用
   NumBPM.Enabled = true;
   CmbSignature.Enabled = true;
  }

  // 核心逻辑：计时器每次“滴答”一下都会执行这里
  private void MetronomeTimer_Tick(object sender, EventArgs e)
  {
   // 1. 拍数加 1
   currentBeat++;

   // 2. 如果当前拍数超过了一小节的总拍数，重置为 1
   if (currentBeat > beatsPerMeasure)
   {
    currentBeat = 1;
   }

   // 3. 播放声音
   PlaySoundForBeat(currentBeat);
  }

  // 辅助方法：解析下拉框选中的文字
  private void ParseTimeSignature()
  {
   // 获取选中的文字，例如 "3/4"
   string selectedSig = CmbSignature.SelectedItem.ToString();

   // 我们只需要斜杠前面的数字
   // Split('/') 会把 "3/4" 分割成 "3" 和 "4"
   string[] parts = selectedSig.Split('/');

   // 取第一个部分，转成数字
   if (parts.Length > 0)
   {
    beatsPerMeasure = int.Parse(parts[0]);
   }

   // 特殊处理 6/8 拍
   // 虽然数学上是6拍，但音乐感觉上通常是两组三连音，或者就是6拍
   // 这里我们简单处理：如果是 6/8，beatsPerMeasure 就是 6
  }

  // 辅助方法：决定播放强音还是弱音
  private void PlaySoundForBeat(int beat)
  {
   // 第一拍永远是强拍
   if (beat == 1)
   {
    // PlaySync() 会卡住界面，Play() 是异步的，适合节拍器
    playerStrong.Play();
   }
   else
   {
    playerWeak.Play();
   }

   // 注意：对于 6/8 拍，有些人习惯第1拍强，第4拍次强。
   // 如果你想进阶，可以在这里写：
   // if (beatsPerMeasure == 6 && beat == 4) { playerStrong.Play(); }
  }
 }
}
