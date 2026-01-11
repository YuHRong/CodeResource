public delegate void EventHandler(object sender, EventArgs e)

 public class Button : Control
{
 public event EventHandler Click;

protected void OnClick(EventArgs e)
 {
  if (Click != null)
   Click(this, e);
 }

 public void Reset()
 {
  Click = null;
 }
}