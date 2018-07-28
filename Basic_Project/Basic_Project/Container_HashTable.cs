using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Container_HashTable
    {
        static void Main(string[] args)
        {
            Hashtable htable = new Hashtable();
            htable.Add("Name","Ramesh");
            htable.Add("Age", 20);
            htable.Add("ContactNo", new string[] { "8888", "9999" });
            htable.Add("Salary", 70000);

            string name = (string)htable["Name"];
            Console.WriteLine("Name is : {0}", name);

            string []phoneNo=(string[])htable["ContactNo"];//It is returning a object so need to typecast

            foreach(string key in htable.Keys)
            {
                Console.WriteLine("Key:{0}  Value:{1}", key, htable[key]);
            }
            htable.Remove("ContactNo");
            //htable.Clear();
           bool result= htable.ContainsKey("Age");
           Console.WriteLine("Age is There:{0}", result);

           foreach(DictionaryEntry dc in htable)
            {
                Console.WriteLine("key:{0} value:{1}", dc.Key, dc.Value);
            }
        }
    }
}
