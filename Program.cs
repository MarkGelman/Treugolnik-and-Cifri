using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnik_Cifr
{
    class Program
    {
        /* .כתוב תוכנית הקולטת מספר ומדפיסה את המשולש הבא:
            לדוגמא עבור: 4
            
            1
            12
            1234
            123
            12
            1
            
            */
        
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
        }
    }
}
