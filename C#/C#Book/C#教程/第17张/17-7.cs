using System;
using System.IO;

struct Record
{
 public string name;
 public UInt16 age;
 public string phone;
 public string address;
};

class PhoneBook
{
 FileStream f_srm;
 string s_filename;
 Record m_record;

 public PhoneBook(string filename)
 {
  s_filename = filename;
 }

 public int Open()
 {
  Console.WriteLine("1: List Record");
  Console.WriteLine("2: Add New Record");
  Console.WriteLine("3: Erase Record");
  Console.WriteLine("0: Exit");
  int i = Console.Read() - '0';
  return i;
 }

 public void AddNew()
 {
  try
  {
   f_srm = new FileStream(s_filename, FileMode.OpenOrCreate);
  }
  catch
  {
   Console.WriteLine("PhoneBook Error!");
   return;
  }

  BinaryWriter pw = new BinaryWriter(f_srm);
  pw.Seek(0, SeekOrigin.End);
  string s_temp;

  Console.Write("Name: ");
  Console.ReadLine();
  m_record.name = Console.ReadLine();
  pw.WriteString(m_record.name);

 reenter:
  Console.Write("Age: ");
  s_temp = Console.ReadLine();
  try
  {
   m_record.age = s_temp.ToUInt16();
  }
  catch
  {
   Console.WriteLine("The format of age is error,please ReEnter");
   goto reenter;
  }
  pw.Write(m_record.age);

  Console.Write("Phone Number: ");
  m_record.phone = Console.ReadLine();
  pw.WriteString(m_record.phone);

  Console.Write("Address: ");
  m_record.address = Console.ReadLine();
  pw.WriteString(m_record.address);

  f_srm.Close();
 }

 public void List()
 {
  try
  {
   f_srm = new FileStream(s_filename, FileMode.Open);
  }
  catch
  {
   Console.WriteLine("PhoneBook Error!");
   return;
  }

  BinaryReader pr = new BinaryReader(f_srm);
  Console.WriteLine("Name Age Phone Number Address");
  Console.WriteLine("***************************************");

  while (true)
  {
   try
   {
    m_record.name = pr.ReadString();
    m_record.age = pr.ReadUInt16();
    m_record.phone = pr.ReadString();
    m_record.address = pr.ReadString();
   }
   catch
   {
    return;
   }

   Console.WriteLine("{0,-9}{1,-6}{2,-18}{3}", m_record.name,
   m_record.age, m_record.phone, m_record.address);
  }

  f_srm.Close();
 }

 public void Erase()
 {
  try
  {
   f_srm = new FileStream(s_filename, FileMode.Create);
  }
  catch
  {
   Console.WriteLine("PhoneBook Error!");
   return;
  }

  f_srm.Close();
  Console.WriteLine("Now the book is empty!");
 }
}

class Test
{
 public static void Main()
 {
  PhoneBook pbook = new PhoneBook("c:\\c#\\file\\Phone.book");
  int i = pbook.Open();

  switch (i)
  {
   case 1:
    pbook.List();
    break;
   case 2:
    pbook.AddNew();
    break;
   case 3:
    pbook.Erase();
    break;
  }
 }
}