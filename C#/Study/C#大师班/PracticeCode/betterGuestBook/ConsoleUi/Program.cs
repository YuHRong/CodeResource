using System;
using System.Collections.Generic;
using System.Xml;
using GuestBookLibrary.Modules;

namespace ConsoleUi
{
 internal class Program
 {
  static void Main(string[] args)
  {
   List<GuestModules> guests = new List<GuestModules>();
   GetGuestInformation();

   foreach (GuestModules guest in guests)
   {
    Console.WriteLine(guest.GuestInfo);
   }
   Console.ReadLine();
  }
  

  private static void GetGuestInformation()
  {
   string moreGuestsComing = "";
   do
   {
    //GuestModules guest = new GuestModules();
    //Console.Write("What your FirstName?");
    //guest.FirstName = Console.ReadLine();
    //Console.Write("What is your last name: ");
    //guest.LastName = Console.ReadLine();
    //Console.Write("What message would you like to tell your host: ");
    //guest.MessageToHost = Console.ReadLine();
    //Console.Write("Are more guests coming (yes/no): ");
    //moreGuestComing = Console.ReadLine();
    //guests.Add(guest);

    GuestModules guest = new GuestModules();
    guest.FirstName = GetInfoFromConsole("What is your name?");
    guest.LastName = GetInfoFromConsole("What is your last name: ");
    guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
    moreGuestsComing = Console.ReadLine(); // 用户输入是否继续添加访客
    Console.Clear();
   } while (moreGuestsComing.ToLower() == "yes");
  }

  private static string GetInfoFromConsole(string message)
  {
   string output = "";
   Console.Write(message);
   output = Console.ReadLine();
   return output;
  }
 }
}

