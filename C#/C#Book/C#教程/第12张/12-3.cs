using System;

public class File
{
 private string s_filename;

 public string Filename
 {
  get
  {
   return s_filename;
  }
  set
  {
   if (s_filename != value)
   {
    s_filename = value;
   }
  }
 }
}

public class Test
{
 public static void Main()
 {
  File f = new File();
  f.Filename = "myfile.txt";
  string s = f.Filename;
 }
}