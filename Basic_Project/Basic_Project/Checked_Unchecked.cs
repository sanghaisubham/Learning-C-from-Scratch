using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Checked_Unchecked
    {
        static void Main(string[] args)
        {
            checked
            {
                unchecked
                {
                    short p = 10000;
                    byte b = (byte)p;
                    Console.WriteLine(b.ToString());
                }
                int x = 50000;
                short y = (short)x;
                Console.WriteLine(y.ToString());
            }
        }
    }
}
