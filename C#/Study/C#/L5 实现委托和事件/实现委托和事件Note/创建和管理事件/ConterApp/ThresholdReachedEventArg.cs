namespace ConterApp;

public class ThresholdReachedEventArgs : EventArgs
{
 public int Threshold { get; set; }
 public DateTime TimeReached { get; set; }

 // public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
 // protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
 // {
  // ThresholdReached?.Invoke(this, e);
 // }

 
}