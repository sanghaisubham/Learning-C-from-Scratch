using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Assignment3
    {
        public void ListData(List<char> list)
        {
            int count1 = list.Count;
            Console.WriteLine(count1);
            List<char> newlist = new List<char>();
            for(int i=count1-1;i>=0;i--)
            {
                newlist.Add(list[i]);
            }

        }
        static void Main(string[] args)
        {
            List<char> charlist = new List<char>();
            charlist.Add('a');
            charlist.Add('b');
            charlist.Add('c');
            charlist.Add('d');
            charlist.Add('e');
            charlist.Add('f');
            charlist.Add('g');
            charlist.Add('h');
            charlist.Add('i');
            charlist.Add('j');
            Assignment3 objas = new Assignment3();
            objas.ListData(charlist);


        }
    }
}
