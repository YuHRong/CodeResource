using System;
using System.Windows.Forms;
//using System.Speech.Synthesis; // 明确指定语音合成
using System.IO;
using NAudio.Wave;
using System.Diagnostics;

namespace MusicPlayerApp
{
 public partial class Form1 : Form
 {
 private WaveOutEvent? outputDevice;
 private AudioFileReader? audioFile;
 private string currentFile = "";
 private bool isPlaying = false;
 private bool isMuted = false;
        private float originalVolume = 0.5f;
 //private Timer positionTimer;
 private System.Windows.Forms.Timer timerProgress;

 public Form1()
 {
 InitializeComponent();
 InitializeAudio();
 }

 private void InitializeAudio()
 {
 outputDevice = new WaveOutEvent();
 outputDevice.Volume = 0.5f;
 
 // 初始化定时器更新进度
 positionTimer = new Timer();
 positionTimer.Interval = 100;
 positionTimer.Tick += PositionTimer_Tick;
 
 trackBarVolume.Value = 50;
 lblVolume.Text = "50%";
 UpdateButtonStates();
 }

 private void PositionTimer_Tick(object sender, EventArgs e)
 {
 if (audioFile != null && outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
 {
 // 更新播放进度显示
 if (audioFile.TotalTime.TotalSeconds > 0)
 {
 var progress = (audioFile.CurrentTime.TotalSeconds / audioFile.TotalTime.TotalSeconds) * 100;
 lblProgress.Text = $"{audioFile.CurrentTime:mm\\:ss} / {audioFile.TotalTime:mm\\:ss}";
 }
 }
 }

 private void UpdateButtonStates()
 {
 btnPlayPause.Enabled = !string.IsNullOrEmpty(currentFile);
 btnStop.Enabled = !string.IsNullOrEmpty(currentFile);
 btnMute.Enabled = !string.IsNullOrEmpty(currentFile);
 }

 private void btnOpen_Click(object sender, EventArgs e)
 {
 using (OpenFileDialog openFileDialog = new OpenFileDialog())
 {
 openFileDialog.Filter = "音频文件|*.wav;*.mp3;*.flac;*.aac;*.m4a;*.wma|所有文件|*.*";
 openFileDialog.Title = "选择音频文件";
 openFileDialog.Multiselect = false;

 if (openFileDialog.ShowDialog() == DialogResult.OK)
 {
 LoadAudioFile(openFileDialog.FileName);
 }
 }
 }

 private void LoadAudioFile(string filePath)
 {
 try
 {
 // 停止当前播放
 StopPlayback();
 
 // 释放之前的资源
 audioFile?.Dispose();
 audioFile = null;

 // 创建新的音频文件读取器
 audioFile = new AudioFileReader(filePath);
 outputDevice!.Init(audioFile);
 
 currentFile = filePath;
 lblStatus.Text = $"已加载: {Path.GetFileName(filePath)}";
 lblFileInfo.Text = $"{GetFileFormat(filePath)} | {audioFile.TotalTime:mm\\:ss}";
 
 UpdateButtonStates();
 isPlaying = false;
 btnPlayPause.Text = "播放";
 
 // 恢复音量设置
 if (outputDevice != null)
 {
 outputDevice.Volume = isMuted ? 0 : originalVolume;
 }
 }
 catch (Exception ex)
 {
 MessageBox.Show($"加载文件失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
 lblStatus.Text = "加载失败";
 UpdateButtonStates();
 }
 }

 private string GetFileFormat(string filePath)
 {
 var ext = Path.GetExtension(filePath).ToUpper().Replace(".", "");
 return ext switch
 {
 "MP3" => "MP3",
 "WAV" => "WAV",
 "FLAC" => "FLAC",
 "AAC" => "AAC",
 "M4A" => "M4A",
 "WMA" => "WMA",
 _ => "未知格式"
 };
 }

 private void btnPlayPause_Click(object sender, EventArgs e)
 {
 if (audioFile == null || outputDevice == null) return;

 try
 {
 if (outputDevice.PlaybackState == PlaybackState.Playing)
 {
 outputDevice.Pause();
 btnPlayPause.Text = "播放";
 lblStatus.Text = "已暂停";
 positionTimer.Stop();
 }
 else
 {
 outputDevice.Play();
 btnPlayPause.Text = "暂停";
 lblStatus.Text = "播放中";
 positionTimer.Start();
 }
 isPlaying = outputDevice.PlaybackState == PlaybackState.Playing;
 }
 catch (Exception ex)
 {
 MessageBox.Show($"播放控制失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
 }
 }

 private void btnStop_Click(object sender, EventArgs e)
 {
 StopPlayback();
 }

 private void StopPlayback()
 {
 if (outputDevice != null)
 {
 outputDevice.Stop();
 if (audioFile != null)
 {
 audioFile.Position = 0; // 重置到开头
 }
 btnPlayPause.Text = "播放";
 lblStatus.Text = "已停止";
 lblProgress.Text = "00:00 / 00:00";
 positionTimer.Stop();
 isPlaying = false;
 }
 }

 private void btnMute_Click(object sender, EventArgs e)
 {
 if (outputDevice == null) return;

 if (!isMuted)
 {
 // 静音
 originalVolume = outputDevice.Volume;
 outputDevice.Volume = 0;
 btnMute.Text = "取消静音";
 lblVolume.Text = "静音";
 isMuted = true;
 }
 else
 {
 // 取消静音
 outputDevice.Volume = originalVolume;
 btnMute.Text = "静音";
 lblVolume.Text = $"{(int)(originalVolume * 100)}%";
 trackBarVolume.Value = (int)(originalVolume * 100);
 isMuted = false;
 }
 }

 private void trackBarVolume_Scroll(object sender, EventArgs e)
 {
 if (outputDevice == null) return;

 var volume = trackBarVolume.Value / 100f;
 outputDevice.Volume = volume;
 originalVolume = volume;
 
 lblVolume.Text = $"{trackBarVolume.Value}%";
 
 if (trackBarVolume.Value == 0)
 {
 btnMute.Text = "取消静音";
 isMuted = true;
 }
 else
 {
 btnMute.Text = "静音";
 isMuted = false;
 }
 }

 // 键盘快捷键支持
 protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
 {
 switch (keyData)
 {
 case Keys.Control | Keys.Up: // Ctrl+↑ 增加音量
 IncreaseVolume();
 return true;
 
 case Keys.Control | Keys.Down: // Ctrl+↓ 减少音量
 DecreaseVolume();
 return true;
 
 case Keys.Space: // 空格键播放/暂停
 if (btnPlayPause.Enabled)
 {
 btnPlayPause.PerformClick();
 return true;
 }
 break;
 
 case Keys.Escape: // ESC键停止
 if (btnStop.Enabled)
 {
 btnStop.PerformClick();
 return true;
 }
 break;
 }
 
 return base.ProcessCmdKey(ref msg, keyData);
 }

 private void IncreaseVolume()
 {
 if (trackBarVolume.Value < trackBarVolume.Maximum)
 {
 trackBarVolume.Value += 5;
 trackBarVolume_Scroll(trackBarVolume, EventArgs.Empty);
 }
 }

 private void DecreaseVolume()
 {
 if (trackBarVolume.Value > trackBarVolume.Minimum)
 {
 trackBarVolume.Value -= 5;
 trackBarVolume_Scroll(trackBarVolume, EventArgs.Empty);
 }
 }

 protected override void OnFormClosed(FormClosedEventArgs e)
 {
 CleanupAudio();
 base.OnFormClosed(e);
 }

 private void CleanupAudio()
 {
 positionTimer?.Stop();
 positionTimer?.Dispose();
 
 outputDevice?.Stop();
 outputDevice?.Dispose();
 audioFile?.Dispose();
 }

 private void chkSpeech_CheckedChanged(object sender, EventArgs e)
 {
 // 语音功能占位
 if (chkSpeech.Checked)
 {
 MessageBox.Show("语音功能将在后续版本中添加", "功能提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
 }
 }

 private void Form1_Load(object sender, EventArgs e)
 {
 // 设置窗口标题和初始状态
 this.Text = "无障碍音乐播放器 - 支持多种格式";
 lblSpeech.Text = "使用说明: 空格键播放/暂停, ESC停止, Ctrl+↑/↓调节音量";
 }
 }
}