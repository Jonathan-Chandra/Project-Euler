using System;
public class One
{
  public int Multiples_of_3_or_5(int n)
  {
    int sum = 0;
    for(int i = 0; i < n; i++)
    {
      if(i % 3 == 0)
      {
        sum += i;
      }
      else if(i % 5 == 0)
      {
         sum += i; 
      }
    }
    return sum;
  }
}
