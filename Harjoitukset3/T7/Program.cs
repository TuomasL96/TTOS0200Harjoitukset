using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            TestThis();
        }
        static void TestThis()
        {
            User user = new User("Pekka", false, true, true);
            Admin admin = new Admin("Tuomas", true, true, true, true, "K2679");
            Console.WriteLine("User:");
            Console.WriteLine(user.ToString());
            Console.WriteLine("Admin:");
            Console.WriteLine(admin.ToString());
        }
    }
}
