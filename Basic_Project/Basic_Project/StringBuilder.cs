/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~String vs StringBuilder~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
  
 * String is immutable in String i.e Cannot be changed once created.Changing initial string will create a
 * new  srtring object on the memory heap instead of modifying the initial string at the same memory
 * address.This will hinder the performance if string is changed multiple times.
 
 To solve this problem StringBuilder was introduced which is a dynamic object that allows us to 
 expand the number of characters in the string.It does not create a new object in memory but 
 dynamically expands memory to accomodate modified string.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{

    class StringBuilders
    {
        static void Main(string[] args)
        {
            string str = "";
       /*string is immutable i.e unmodifiable/unchangeable .
       Once string object is created its data or state cant be changed but a new string obj is created
       When any new string is concatenated to the previous string, the older object is not changed
       but a new obj. is created.*/
            for (int i = 100; i <= 120; i++)
            {
                str += i + "\n";
            }
            Console.WriteLine(str);
            StringBuilder builder = new StringBuilder();
            for (int i = 100; i <= 120; i++)
            {
                // builder.Append(i);
                builder.AppendFormat("The Number is:{0}", i);
                builder.AppendLine();
            }
            builder.AppendFormat("The Length Is : {0}", builder.Length);
            builder.Insert(0, new char[] { '@', '#', '$' });
            builder.Remove(0,3);
            Console.WriteLine(builder);
            /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
            string s = "abcb def";
            Console.WriteLine(s.IndexOf('n'));
            string[] parts = s.Split();
            Console.WriteLine("");
            Console.WriteLine("After Splitting:");
            Console.WriteLine("---------------");
            foreach(string i in parts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            string newstring = string.Join("@", parts);
            Console.WriteLine(newstring);
            newstring = newstring.Replace("b", "##");
            Console.WriteLine(newstring);
        }
    }
}
