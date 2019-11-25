using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsLibrary
{
  public class DemoCode
  {

    public int GrandparentMethod(int position)
    {
      int output = 0;
      Console.WriteLine("open connection");
      try
      {
        output = ParentMethod(position);
      }
      catch (Exception ex)
      {
        // Do some logging
        throw new ArgumentException("You passed in bad data", ex);
        //throw;
      }
      finally
      {
        Console.WriteLine("close connection");
      }

      return output;
    }

    public int ParentMethod(int position)
    {
      return GetNumber(position);
    }

    public int GetNumber(int position)
    {
      int output = 0;

      int[] numbers = new int[] { 1, 4, 7, 2 };
      output = numbers[position];

      return output;
    }
  }
}
