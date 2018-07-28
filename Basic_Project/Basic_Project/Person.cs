using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Person
    {
        public string Name;
        public int age;
        public void PersonDetails()
        {
            Console.WriteLine("The Name is: {0}",Name);
            Console.WriteLine("The Age is: {0}",age);
        }
    }
    class People
    {
        
        List<Person> list= new List<Person>();
        public void AddPerson(Person p)
        {
            list.Add(p);
        }
        public void Print()
        {
            foreach(Person i in list)
            {
                /* Here we dont have to create any object of the class to call the member function 
                   because i refers to that Person class itself here */
                i.PersonDetails();
            }
        }
    }
    class MyMain
    {
        static void Main(string[] args)
        {
           
            Person pobj ;
            //pobj.Name = "Subham";
            //pobj.age = 21;
            People peobj=new People();
            //peobj.AddPerson(pobj);
            //peobj.Print();
            char choice = 'y';
            
            while (choice!='q')
            {
                /*If we dont reintialise the object here, the object address remains the same 
                 and again and again same object with the same reference(address) is pushed in the list*/
                pobj = new Person();
                Console.WriteLine("Enter the Name of the Person");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age");
                int age = Convert.ToInt32(Console.ReadLine());
                pobj.Name = name;
                pobj.age =  age;
                peobj.AddPerson(pobj);
                
                Console.WriteLine("Enter q to quit and any other key to continue");
                choice = Convert.ToChar(Console.ReadLine());
            }
            peobj.Print();
        }
    }
}
