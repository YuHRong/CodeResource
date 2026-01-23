using System;

interface ISequence
{
 int Count 
 { 
  get;
  set;
 }
}

interface IRing
{
 void Count(int i);
}

interface IRingSequence : ISequence, IRing
{
}

class C
{
 void Test(IRingSequence rs)
 {
  // rs.Count(1); 
  // 错误, Count 有二义性 

  // rs.Count = 1; 
  // 错误, Count 有二义性 

  ((ISequence)rs).Count = 1;
  // 正确

  ((IRing)rs).Count(1);
  // 正确调用 IRing.Count
 }
}