// using System.Formats.Asn1;

// namespace ConterApp;

public class Counter
{
 public int Total { get; private set; }
 public int Threshold { get; set; }

 public Counter(int threshold)
 {
  Threshold = threshold;
  Total = 0;
 }

 public void Add(int value)
 {
  Total += value;
  Console.WriteLine($"Current Total: {Total}"); // Debugging output
  if (Total >= Threshold)
  {
   // OnThresholdReached(EventArgs.Empty);
   var args = new ThresholdReachedEventArgs
   {
    Threshold = Threshold,
    TimeReached = DateTime.Now
   };
  }
 }

 public event EventHandler ThresholdReached = delegate { };

 // protected virtual void OnThresholdReached(EventArgs e)
 protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
 {
  ThresholdReached?.Invoke(this, e);
 }

}