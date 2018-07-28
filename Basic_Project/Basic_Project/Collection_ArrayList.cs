using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Collection_ArrayList
    {
        static void Main(string[] args)
        {
            object obj = 10; //boxing(Coversion from value type to reference type)

            int x = (int)obj;//unboxing(Conversion from reference type to value type)

            //object class is in top in hierracrchy, so it can hold refernce of any class

            object newobj = new P();//upcasting

            P p_obj = (P)newobj;    //downcasting

            //--------------------------------------------------------
            //part of collection namespace
            ArrayList list = new ArrayList();

            //list.Add(100); //boxing done here
            //list.Add('c'); //boxing done here
            //list.Add("HELLO"); //boxing done here
            //list.Add(120.456); //boxing done here
            //list.Add(new P()); //upcasting
            //list.Add(new int[] { 10, 20, 30 });

            //IN a list we can append a mixture of Integers,Characters ,Strings etc.

            list.Add(100);
            list.Add(200);
            list.Add(300);

            ArrayList list2 = new ArrayList() { 1000, 2000, 3000 };

            //Pass a Collection using Addrange
            list.AddRange(new int[] { 5000, 5000, 60000 });

            //Removal
            list.Remove(5000);//for multiple values present it will remove only the first occurence
            list.RemoveAt(2);
            list.RemoveRange(2, 1);

            //Insertion
            list.Insert(1, 999);
            list.InsertRange(2, new int[] { 1, 2, 3, 4 });
            list.InsertRange(2, list2);

            //Updation
            list[2] = 1000;

            //Length
            Console.WriteLine("The Count is {0}", list.Count);

            //Searching

            bool result = list.Contains(111);//return boolean value
            Console.WriteLine("The List Contains 111:  {0}", result);

            //Empty The List
            //list.clear();

            int sizelist = list.Count;
            int[] ary = new int[sizelist];

            list.CopyTo(ary);
            list.CopyTo(ary, 0);
            list.CopyTo(2, ary, 0, 3);

            object[] ary2 = list.ToArray();

            foreach (int y in ary2)
            {
                Console.WriteLine(y);
            }

            //Generic List Type
            List<int> list3 = new List<int>();
        }
    }
    class P
    {

    }
}
