using System;
using System.Media;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. 获取当前时间
            DateTime now = DateTime.Now;

            // 2. 更新Label显示
            lblTime.Text = now.ToString("HH:mm:ss");

            // 3. 整点报时检测（只在整点的第0秒执行）
            if (now.Minute == 0 && now.Second == 0)
//            if (true)
            {
                int hourToPlay;

                // 特殊处理：24点（0点）播放0.wav
                if (now.Hour == 0)
                {
                    hourToPlay = 0; // 播放"零点"
                }
                // 12点播放12.wav
                else if (now.Hour == 12)
                {
                    hourToPlay = 12; // 播放"12点"
                }
                // 其他时间按12小时制报时
                else
                {
                    hourToPlay = now.Hour % 12; // 取余数，1-11点对应1.wav-11.wav
                }

                // 4. 构建音效文件路径
                string soundFilePath = $"Sounds/{hourToPlay}.wav";

                // 5. 播放音效
                try
                {
                    var player = new SoundPlayer(soundFilePath);
                    player.Play(); // 异步播放，不会阻塞时钟
                }
                catch (Exception)
                {
                    // 忽略播放错误
                }
            }
        }
    }
}