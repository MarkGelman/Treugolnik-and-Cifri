using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnik_Cifr
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int mult = 0;
            int i = 1;
            while (i <= num)
            {
                mult += i;
                if (i == num - 1)
                {
                    i++;
                    mult *= 10;
                    continue;
                }
                Console.WriteLine(mult);
                mult *= 10;
                i++;
            }
            mult /= 10;
            while (mult != 1)
            {
                mult /= 10;
                Console.WriteLine(mult);
            }

            /*for (int i=1; i<=num;i++)
              {
                    for (int j=1; j<=i; j++)
                    {
                        if (i == num - 1)
                            break;
                        if (j!=i-1)
                            Console.Write(j);
                        else
                            Console.WriteLine(j);
                    }
              }
            for (int i = num-1; i>0;i--)
             {
                for (int j = 1; j <= i; j++)
                {
                    if (j != i - 1)
                        Console.Write(j);
                    else
                        Console.WriteLine(j);
                }
            }*/
        }
    }
}
