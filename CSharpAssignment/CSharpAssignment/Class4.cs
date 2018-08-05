using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Class4
    {
        static void Main(string[] args)
        {
            List<char> charlist = new List<char>() ;
            string str = "Subham Sanghai";
            foreach(char ch in str)
            {
                charlist.Add(ch);
            }
            Class4 obj = new Class4();
            obj.ListData(charlist);
        }

        public void printlist(List<char> li)
        {
            foreach(char ch in li)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
        public void ListData(List<char> list)
        {
            Console.WriteLine("Size of the list is :: {0}", list.Count);
            printlist(list);
            List<char> newcharlist = new List<char>();
            for(int i = list.Count - 1; i >= 0; i--)
            {
                newcharlist.Add(list[i]);
            }
            printlist(newcharlist);
        }
    }


}
