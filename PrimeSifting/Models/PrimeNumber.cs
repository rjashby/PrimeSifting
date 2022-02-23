namespace PrimeSifting
{
  public class PrimeNumber
  {
    public bool CreateList(int num) 
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
  }
}