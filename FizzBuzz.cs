using System.Globalization;
using System.Runtime.InteropServices;

namespace Practice;


public class FizzBuzz
{
    /// <summary>
    /// This code resolves the FizzBuzz problem.
    /// <summary>
    public static void Solution()
    {
        int n = 100; 
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
