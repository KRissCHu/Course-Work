using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_48a
{
    class EX_48_a
    {
        static void Main(string[] args)
        {
            int y;
            int x = int.Parse(Console.ReadLine());

            if(x<=0)
            {
                y = (5 * x) + 1;
            }
            else
            {
                y = 1 - x;
            }
        }
    }
}
