﻿using ExceptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {

      DemoCode demoCode = new DemoCode();
      try
      {

        int result = demoCode.GrandparentMethod(4);
        Console.WriteLine($"The value at the given position is {result}");
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine("You gave us bad information.  Bad user!");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);

        var inner = ex.InnerException;

        while (inner != null)
        {
          Console.WriteLine(inner.StackTrace);
          inner = inner.InnerException;
        }
      }

      Console.ReadLine();
    }
  }
}
