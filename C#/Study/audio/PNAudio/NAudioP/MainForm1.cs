using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace NAudioP;

public class MainForm : Form
{
 private WaveOut outputDevice;
 private AudioFileReader audioFile;

 public MainForm()
 {
  InitializeComponent();
 }

 private void InitializeComponent()
 {
  var flowPanel = new FlowLayoutPanel();
  flowPanel.FlowDirection = FlowDirection.LeftToRight;
  flowPanel.Margin = new Padding(10);

  var buttonPlay = new Button();
  buttonPlay.Text = "Play";
  buttonPlay.Click += OnButtonPlayClick;
  flowPanel.Controls.Add(buttonPlay);

  var buttonStop = new Button();
  buttonStop.Text = "Stop";
  buttonStop.Click += OnButtonStopClick;
  flowPanel.Controls.Add(buttonStop);

  this.Controls.Add(flowPanel);

  this.FormClosing += OnButtonStopClick;


  var wo = new WaveOut();
  var af = new AudioFileReader(@"example.mp3");
  var closing = false;
  wo.PlaybackStopped += (s, a) => { if (closing) { wo.Dispose(); af.Dispose(); } };
  wo.Init(af);

  var f = new Form();
  var b = new Button() { Text = "Play" };
  b.Click += (s, a) => wo.Play();
  var b2 = new Button() { Text = "Stop", Left = b.Right };
  b2.Click += (s, a) => wo.Stop();
  var b3 = new Button { Text = "Rewind", Left = b2.Right };
  b3.Click += (s, a) => af.Position = 0;
  f.Controls.Add(b);
  f.Controls.Add(b2);
  f.Controls.Add(b3);
  f.FormClosing += (s, a) => { closing = true; wo.Stop(); };

  //f.ShowDialog();
  var t = new TrackBar() { Minimum = 0, Maximum = 100, Value = 100, Top = b.Bottom, TickFrequency = 10 };
  t.Scroll += (s, a) => wo.Volume = t.Value / 100f;
  t.Scroll += (s, a) => af.Volume = t.Value / 100f;

 //Alternative: t.Scroll += (s, a) => af.Volume = t.Value / 100f;
  //f.Controls.AddRange(new Control[] { b, b2, b3, t });
  //f.FormClosing += (s, a) => { closing = true; wo.Stop(); };


  //var volumeTrackBar = new TrackBar() { Minimum = 0, Maximum = 100, Value = 100, Dock = DockStyle.Bottom };
  //volumeTrackBar.Scroll += (s, a) => { if (audioFile != null) audioFile.Volume = volumeTrackBar.Value / 100f; };
  //this.Controls.Add(volumeTrackBar);
 }

 private void OnButtonPlayClick(object sender, EventArgs args)
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

 private void OnButtonStopClick(object sender, EventArgs args)
 {
  outputDevice?.Stop();
 }

 private void OnPlaybackStopped(object sender, StoppedEventArgs args)
 {
  outputDevice.Dispose();
  outputDevice = null;
  audioFile.Dispose();
  audioFile = null;
 }
}
