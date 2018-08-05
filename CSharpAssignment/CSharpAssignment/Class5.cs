using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Class5
    {
        static void Main(string[] args)
        {
            resources obj = new resources();
            db.AllUsers = new List<User>();
            User obj1 = new User("abc", "123");
            User obj2 = new User("xyz", "123");
            db.AllUsers.Add(obj1);
            db.AllUsers.Add(obj2);
            
            obj.init("abc", "123");
            obj.init("pqr", "123");
            obj.init("abc", "13");
            
        }
    }
    class User
    {
        public string username;
        public string password;
        public User(string uname, string pwd)
        {
            this.username = uname;
            this.password = pwd;
        }
    }
    class db
    {
        public static List<User> li;
       public static List<User> AllUsers { get; set; }

    }

    class security
    {
        public static bool authenticate(User u)
        {
            
            for(int i=0;i<db.AllUsers.Count;i++)
            {
                if (db.AllUsers[i].username == u.username && db.AllUsers[i].password == u.password)
                    return true;
            }
            return false;
        }
    }

    class resources
    {
        void GetDate()
        {
            Console.WriteLine(DateTime.Now);
        }
        public void init(string uname, string pwd)
        {
            User u = new User(uname, pwd);
            if (security.authenticate(u))
            {
                GetDate();
            }
            else
                Console.WriteLine("Access Denied");
        }
    }
}
