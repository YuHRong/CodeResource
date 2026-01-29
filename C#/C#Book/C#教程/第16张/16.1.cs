// 库文件 WelcomeLibrary.cs
namespace MyProgram.CSharp.FirstApp
{
 public class WelcomeMessage
 {
  string m_message;

  public WelcomeMessage()
  {
   m_message = "Welcome !";
  }

  public string Message
  {
   get 
   {
    return m_message; 
   }
   set
   {
    m_message = value; 
   }
  }
 }
}