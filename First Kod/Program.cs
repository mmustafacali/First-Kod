using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Kod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");

            int r = Convert.ToInt32(Console.ReadLine());

            if (r < 0)
            {
                Console.WriteLine($"|{r}| = {r * -1}");
            }
            else
            {
                Console.WriteLine($" |{r}| = {r}");
            }
            Console.ReadKey();
        }
    }
}
