using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace AudioApp
{
 public partial class Form1 : Form
 {
  private WaveOut outputDevice;
  private AudioFileReader audioFile;

  public Form1()
  {
   InitializeComponent();
  }

  private void OnPlaybackStopped(object sender, StoppedEventArgs args)
  {
   outputDevice.Dispose();
   outputDevice = null;
   audioFile.Dispose();
   audioFile = null;
  }

  private void OnButtonStop_Click(object sender, System.EventArgs e)
  {
   outputDevice?.Stop();
  }

  private void OnButtonPlay_Click(object sender, System.EventArgs e)
  {
   if (outputDevice == null)
   {
    outputDevice = new WaveOut();
    outputDevice.PlaybackStopped += OnPlaybackStopped;
   }
   if (audioFile == null)
   {
    audioFile = new AudioFileReader(@"E:\example.mp3");
    outputDevice.Init(audioFile);
   }
   outputDevice.Play();
  }
 }
}
