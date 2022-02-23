using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeSifting
{
  public class PrimeNumber
  {
    public static CreateList(int num) 
    {
      List<int> myNums = new List<int> {};
      while (num >= 2)
      {
        myNums.Add(num);
        num = num - 1;
      }
      myNums.Reverse();
      foreach (int shoes in myNums) 
      {
        Console.WriteLine(shoes);
      }
    }

    public static List<int> Primes(int input)
    {
      CreateList(input);
      foreach (int bacon in myNums)
      {
        if (bacon % bacon = 0 && bacon % 1 == 0)
        {
          myNums.Remove(bacon);
        }
      }
      return myNums;
    }
  }
}