using System;
using System.Net;

class ResolveDNS
{
 IPAddress[] m_arrayIPs;

 public Resolve(string s_host)
 {
  IPHostEntry iP = Dns.GetHostByName(s_host);
  m_arrayIPs = iP.AddressList;
 }

 public IPAddress this[int nIndex]
 {
  get
  {
   return m_arrayIPs[nIndex];
  }
 }

 public int IPLength
 {
  get
  {
   return m_arrayIPs.Length;
  }
 }
}

class TestApp
{
 public static void Main()
 {
  ResolveDNS resolver1 = new ResolveDNS();
  resolver1.Resolve("www.sohu.com");
   int n = resolver1.IPLength;

  Console.WriteLine("Get the IP Address of the host");
  Console.WriteLine();

  for(int i = 1; i < new; i++)
  {
   Console.WriteLine(resolver1[i]);
  }
 }
}