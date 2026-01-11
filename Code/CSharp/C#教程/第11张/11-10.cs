using System;

class Player
{
 public int neili;
 public int tili;
 public int jingyan;
 public int neili_r;
 public int tili_r;

 public Player()
 {
  neili = 10;
  tili = 50;
  jingyan = 0;
  neili_r = 50;
  tili_r = 50;
 }
 public static Player operator ++(Player p)
 {
  p.neili = p.neili + 50;
  p.tili = p.tili + 100;
  p.neili_r = p.neili;
  p.tili_r = p.tili;
  return p;
 }

 public void Show()
 {
  Console.WriteLine("Tili: {0}", tili);
  Console.WriteLine("Jingyan: {0}", jingyan);
  Console.WriteLine("Neili: {0}", neili);
  Console.WriteLine("Tili_full: {0}", tili_r);
  Console.WriteLine("Neili_full: {0}", neili_r);
 }
}

class Test
{
 public static void Main()
 {
  Player man = new Player();
  man.Show();
  man++;
  Console.WriteLine("Now upgrading...:");
  man.Show();
 }
}