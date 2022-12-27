using System.Diagnostics;
using System.Linq.Expressions;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 12546;
            int a = n % 10;
            int b = n / 10 % 10;
            int c = ((n / 100) % 10) % 10;
            int d = ((n / 1000) % 10) % 10;
            int f = (((n / 10000) % 10) % 10) % 10;
              if ( a!= b && b!=c && c!=d && d!=f) 
            {
                Console.WriteLine($"{a}!={b}!={c}!={d}!={f}");
                Console.WriteLine("Muxtelif");                                    
            }
              else 
                {
                Console.WriteLine($"{a}!={b}!={c}!={d}!={f}");
                Console.WriteLine("Muxtelif Deyil");
            }
          
        }
    }
}