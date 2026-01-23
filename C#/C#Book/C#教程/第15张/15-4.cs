using System;

interface ISequence
{
 object Add();
}

interface IRing
{
 int Insert(object obj);
}

class RingSequence : ISequence, IRing
{
 public object Add()
 {

 }

 public int Insert(object obj)
 {

 }
}