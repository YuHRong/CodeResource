/* public class Button
{
 // Nullable to indicate no subscribers initially
 public event EventHandler? Selected;

 public void OnClick()
 {
  // If subscribers exist, ?.Invoke syntax triggers an event
  Selected?.Invoke(this, EventArgs.Empty);
 }
}

// Subscribing to the event
Button button = new Button();
button.Selected += (sender, e) => Console.WriteLine("Button Selected!");

// Triggering the event
button.OnClick(); // Output: "Button Selected!" */

/* 
// Define a delegate
public delegate void ButtonClickedHandler(object sender, EventArgs e);

// Use the delegate in an event
public class Button
{
    public event ButtonClickedHandler Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty); 
    }
} */

/* 
public class Counter
{
 public event EventHandler ThresholdReached;

 protected virtual void OnThresholdReached(EventArgs e)
 {
  ThresholdReached?.Invoke(this, e);
 }

 public void Increment(int value, int threshold)
 {
  if (value >= threshold)
  {
   OnThresholdReached(EventArgs.Empty);
  }
 }
}

// Subscribing to the event
Counter counter = new Counter();
counter.ThresholdReached += (sender, e) => Console.WriteLine("Threshold reached!");

// Triggering the event
counter.Increment(10, 5); // Output: "Threshold reached!" */

/* 
public class BaseCounter
{
    public event EventHandler ThresholdReached;

    protected virtual void OnThresholdReached(EventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }

    public void Increment(int value, int threshold)
    {
        if (value >= threshold)
        {
            OnThresholdReached(EventArgs.Empty);
        }
    }
}

public class AdvancedCounter : BaseCounter
{
    protected override void OnThresholdReached(EventArgs e)
    {
        Console.WriteLine("AdvancedCounter: Threshold reached!");
        base.OnThresholdReached(e);
    }
}

// Usage
AdvancedCounter counter = new AdvancedCounter();
counter.ThresholdReached += (sender, e) => Console.WriteLine("Subscriber: Threshold reached!");
counter.Increment(10, 5);
// Output:
// AdvancedCounter: Threshold reached!
// Subscriber: Threshold reached!
 */

/* 
public class Button
{
    public event EventHandler Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

public class Program
{
    public static void Main()
    {
        Button button = new Button();
        button.Clicked += Button_Clicked;

        button.OnClick(); // Output: "Button was clicked!"
    }

    private static void Button_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Button was clicked!");
    }
} */

/*public class Button
{
    public event EventHandler Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

public class Program
{
    public static void Main()
    {
        Button button = new Button();
        EventHandler handler = Button_Clicked;

        button.Clicked += handler;
        button.Clicked -= handler;

        button.OnClick(); // No output, as the handler was unsubscribed.
    }

    private static void Button_Clicked(object sender, EventArgs e)
    {
        Console.WriteLine("Button was clicked!");
    }
}  */

/* public class Button
{
    public event EventHandler Clicked;

    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }
}

public class Program
{
    public static void Main()
    {
        Button button = new Button();
        bool isSubscribed = false;

        EventHandler handler = (sender, e) => Console.WriteLine("Dynamic handler executed!");

        if (!isSubscribed)
        {
            button.Clicked += handler;
            isSubscribed = true;
        }

        button.OnClick(); // Output: "Dynamic handler executed!"

        if (isSubscribed)
        {
            button.Clicked -= handler;
            isSubscribed = false;
        }

        button.OnClick(); // No output, as the handler was unsubscribed.
    }
} */

/*  */

