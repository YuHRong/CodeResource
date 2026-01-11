using System;
using System.Media;
using System.Timers;

namespace MusicPlayerApp
{
    public class MusicPlayer
    {
        private SoundPlayer? soundPlayer;
        private System.Timers.Timer? progressTimer;
        private bool isPlaying = false;
        private TimeSpan totalTime = TimeSpan.Zero;
        private TimeSpan currentPosition = TimeSpan.Zero;

        public event EventHandler<TimeSpan>? PositionChanged;
        public event EventHandler? PlaybackStopped;

        public bool IsPlaying => isPlaying;
        public TimeSpan TotalTime => totalTime;
        public TimeSpan CurrentPosition => currentPosition;

        public MusicPlayer()
        {
            // 初始化进度计时器
            progressTimer = new System.Timers.Timer(100); // 每100毫秒更新一次
            progressTimer.Elapsed += ProgressTimer_Elapsed;
        }

        public void Load(string filePath)
        {
            Stop();
            
            try
            {
                soundPlayer = new SoundPlayer(filePath);
                soundPlayer.Load(); // 预加载文件
                
                // 这里简化处理，实际应用中可能需要更准确的方法获取音频时长
                totalTime = TimeSpan.FromSeconds(180); // 假设3分钟，实际需要根据文件计算
                currentPosition = TimeSpan.Zero;
                
                OnPositionChanged(currentPosition);
            }
            catch (Exception ex)
            {
                throw new Exception($"加载文件失败: {ex.Message}");
            }
        }

        public void Play()
        {
            if (soundPlayer == null) return;
            
            soundPlayer.Play();
            isPlaying = true;
            progressTimer?.Start();
        }

        public void Pause()
        {
            if (soundPlayer == null) return;
            
            soundPlayer.Stop();
            isPlaying = false;
            progressTimer?.Stop();
        }

        public void Stop()
        {
            if (soundPlayer == null) return;
            
            soundPlayer.Stop();
            isPlaying = false;
            progressTimer?.Stop();
            currentPosition = TimeSpan.Zero;
            OnPositionChanged(currentPosition);
            OnPlaybackStopped();
        }

        public void SetVolume(float volume)
        {
            // SoundPlayer不支持直接音量控制，实际应用中可能需要使用其他音频库
            // 这里保持空实现或使用系统音量控制
        }

        public void SetPosition(TimeSpan position)
        {
            if (soundPlayer == null) return;
            
            // SoundPlayer不支持直接定位，实际应用中可能需要使用其他音频库
            // 这里简化处理，只更新显示位置
            currentPosition = position;
            OnPositionChanged(currentPosition);
        }

        private void ProgressTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (isPlaying && totalTime > TimeSpan.Zero)
            {
                currentPosition = currentPosition.Add(TimeSpan.FromMilliseconds(100));
                
                if (currentPosition >= totalTime)
                {
                    Stop();
                }
                else
                {
                    OnPositionChanged(currentPosition);
                }
            }
        }

        protected virtual void OnPositionChanged(TimeSpan position)
        {
            PositionChanged?.Invoke(this, position);
        }

        protected virtual void OnPlaybackStopped()
        {
            PlaybackStopped?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            Stop();
            progressTimer?.Dispose();
            soundPlayer?.Dispose();
        }
    }
}