
using System.Net.Sockets;

namespace mPlay;

public class MusicPlayer : ISkipControl, IVolumeControl
{
 public void Play()
 {
  // Implementation
 }
 public void Pause()
 {
  // Implementation
 }
 public bool IsPlaying { get; private set; }

 public void SkipToNext()
 {
  /* Implementation */
 }
 public void AdjustVolume(int level)
 {
  /* Implementation */
 }
}
