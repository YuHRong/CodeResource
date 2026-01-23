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
using System.IO; // 用于文件检查

namespace time
{
    public partial class Form1 : Form
    {
        // 声明变量
        private DateTime startTime; // 记录开始计时的时间点
        private TimeSpan pausedTime; // 记录暂停时已经过去的时间
        private bool isRunning = false; // 标记计时器是否正在运行
        private bool isPaused = false; // 标记计时器是否处于暂停状态
        private SoundPlayer tickPlayer; // 滴答声音效播放器
        private int lastSecond = -1; // 记录上一次播放滴答声的秒数

        public Form1()
        {
            InitializeComponent();
            this.Text = "计时器"; // 添加这行代码

            // 初始化滴答声音效
            InitializeTickSound();
        }

        private void InitializeTickSound()
        {
            try
            {
                string tickSoundPath = Path.Combine("Sounds", "tick.wav");
                if (File.Exists(tickSoundPath))
                {
                    tickPlayer = new SoundPlayer(tickSoundPath);
                }
                // 如果tick.wav不存在，程序会静音运行，不会报错
            }
            catch (Exception ex)
            {
                // 初始化失败时静音处理
                Console.WriteLine("滴答声音效初始化失败: " + ex.Message);
            }
        }

        private void PlayStartSound()
        {
            try
            {
                string soundPath = Path.Combine("Sounds", "start.wav");

                // 检查文件是否存在
                if (File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.Play(); // 异步播放，不阻塞界面
                }
                else
                {
                    // 如果文件不存在，播放系统默认声音
                    SystemSounds.Beep.Play();
                }
            }
            catch (Exception ex)
            {
                // 如果出现任何错误，播放系统声音
                SystemSounds.Beep.Play();
            }
        }

        private void PlayTickSound()
        {
            try
            {
                // 只在计时器运行且未暂停时播放滴答声
                if (isRunning && !isPaused && tickPlayer != null)
                {
                    // 获取当前时间的秒数
                    TimeSpan elapsed = DateTime.Now - startTime + pausedTime;
                    int currentSecond = (int)elapsed.TotalSeconds;

                    // 只有当秒数变化时才播放滴答声（避免重复播放）
                    if (currentSecond != lastSecond)
                    {
                        tickPlayer.Play();
                        lastSecond = currentSecond; // 更新最后播放的秒数
                    }
                }
            }
            catch
            {
                // 播放失败时静音处理
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            // 计算从开始到现在过去了多少时间（如果暂停了，就加上暂停前的时间）
            TimeSpan elapsed;
            if (isPaused)
            {
                elapsed = pausedTime;
                lastSecond = -1; // 暂停时重置秒数记录
            }
            else
            {
                elapsed = DateTime.Now - startTime + pausedTime;

                // 在计时过程中播放滴答声
                PlayTickSound();
            }

            // 将时间格式化成 "时:分:秒" 的字符串
            string timeString = elapsed.ToString(@"hh\:mm\:ss");

            // 更新标签的显示
            labelTime.Text = timeString;

            // 根据状态更新窗体标题
            if (!isRunning)
            {
                this.Text = "计时器 - 已就绪";
                lastSecond = -1; // 重置时重置秒数记录
            }
            else if (isPaused)
            {
                this.Text = $"计时器 - 已暂停 {timeString}";
            }
            else
                this.Text = $"计时器 - 运行中 {timeString}";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                // 播放开始音效（只有第一次启动时播放）
                PlayStartSound();

                // 如果是第一次启动
                startTime = DateTime.Now;
                pausedTime = TimeSpan.Zero;
                isRunning = true;
                isPaused = false;
                lastSecond = -1; // 重置秒数记录
                timerClock.Start(); // 启动定时器
                this.Text = "计时器 - 运行中 00:00:00";
            }
            else if (isPaused)
            {
                // 如果是从暂停状态恢复，不播放开始音效
                startTime = DateTime.Now; // 重置开始时间点，以当前时间为准
                isPaused = false;
                lastSecond = -1; // 重置秒数记录
                timerClock.Start();
                buttonPause.Text = "暂停"; // 恢复按钮文字

                // 立即播放一次滴答声，让用户知道计时已继续
                if (tickPlayer != null)
                {
                    tickPlayer.Play();
                }
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (isRunning && !isPaused)
            {
                // 只有在运行且未暂停时，才能暂停
                pausedTime = DateTime.Now - startTime + pausedTime; // 累计已过去的时间
                isPaused = true;
                timerClock.Stop(); // 停止定时器
                buttonPause.Text = "继续"; // 改变按钮文字
                lastSecond = -1; // 暂停时重置秒数记录

                // 更新标题显示暂停状态
                string timeString = pausedTime.ToString(@"hh\:mm\:ss");
                this.Text = $"计时器 - 已暂停 {timeString}";
            }
            else if (isPaused)
            {
                // 如果已经是暂停状态，点击后变为继续（即调用开始按钮的逻辑）
                buttonStart_Click(sender, e); // 直接调用开始按钮的点击事件
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // 停止计时器，并重置所有状态
            timerClock.Stop();
            isRunning = false;
            isPaused = false;
            pausedTime = TimeSpan.Zero;
            lastSecond = -1; // 重置秒数记录
            labelTime.Text = "00:00:00"; // 重置显示
            buttonPause.Text = "暂停"; // 确保暂停按钮文字正确
            this.Text = "计时器 - 已就绪"; // 重置时恢复默认标题
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // 检查计时器是否在运行
            if (isRunning && !isPaused)
            {
                DialogResult result = MessageBox.Show("计时器正在运行，确定要退出吗？",
                "退出确认",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // 空方法，可以删除或保留
        }
    }
}