using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class _2Darray
    {
        static void Main(string[] args)
        {
            int[,] arry = new int[2, 3];
            arry[0, 0] = 10;
            arry[0, 1] = 12;
            arry[0, 2] = 13;
            arry[1, 0] = 21;
            arry[1, 1] = 24;
            arry[1, 2] = 26;

            int[,] ary2 = { { 11,22,33},
                            {44,55,66 },
                            {77,88,99 }
                            };
            for (int r = 0; r < ary2.GetLength(0); r++)
            {
                for (int c = 0; c < ary2.GetLength(1); c++)
                {
                    Console.Write(ary2[r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------");
            //Jagged Array

            int[][] jary = {
                                new int[] { 100,200,300},
                                new int[] { 10,20,30,40,50,60},
                                new int[] { 60, 70, 80, 90 }

                            };
            int[] temp;
            for(int i=0;i<jary.Length;i++)
            {
                temp=jary[i];
                for (int j = 0; j < temp.Length; j++)
                    Console.Write(temp[j] + " ");
                Console.WriteLine();
            }

        }
    }
}
