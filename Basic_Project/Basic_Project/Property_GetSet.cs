/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Properties~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Property is a member that represents an item 
 * Type of variable that stores the values of an obj. of a class /structure.
 * Helps us define a property as read-only,write-only,read/write type
 * It is of 2 types:
 * => Get=>accessor is used to retrieve values from a property
 * => Set=>accessor is used to assign value or a property
 
 */
 /*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Auto Implemented Properties~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
  * Allows to just declare the property without declaring backing field.
  * Compiler allocates storage for us , based on type of the property
  * Cannot supply bodies of accessors-must simply be declared as semicolons.
  * Cannot access 
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Project
{
    class Properties
    {
        string name; // by deafult its private
        public byte age;
        /*If we use private we can  neither read it not write it, 
         * so to make it read only or write only we use property*/

        //name is private but Name Property is public

        public string Name //Declaring a Property(to control access on a data member)
                           //Making read only or write only
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            //value is a keyword here, the value assigned at the bottom is directly assigned to value
            }
        }
        public void SetName(string n)
        {
            name = n;
        }
        public string ContactNo
        /*automatically implementatable property because no need to write anything within get or set 
         (that is auto implemented),no need to either mention the variable names in this case beacause 
         compiler by itself creates instances*/
        {
            get; set; //Outside class nobody can access , so it is read-only

        }

    }
    class Property_GetSet
    {
        static void Main(string[] args)
        {
            Properties p = new Properties();
            p.age = 20;
            p.Name = "Mahesh";
            p.SetName("Mahesh");
            p.ContactNo = "3456789";
            /*the instance for this is automatically assigned by the compiler 
            even if we dont have any variable for Contact No predeclared*/

            //p.Name = "Mahesh";//for public both get and set are allowed
            //for private neither we can get nor set a value

            //get or retrieval
            Console.WriteLine(p.Name + " " + p.age + " " + p.ContactNo);
        }

    }
}
