using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary;

namespace TesterProgram
{
    class ClassTester
    {
        static void Main(string[] args)
        {

            Student s1 = new Student("Sean", "McKinney","A123", 3.59f);
            Student s2 = new Student("Bitty", "B", "B123", 4.00f);
            Console.WriteLine(s1);
            Console.WriteLine(s2);


            Vehicle v1 = new Vehicle("Ford", "Mustang", 1974, 3500f);
            Vehicle v2 = new Vehicle("Jeep", "Wrangler", 2008, 2700f);
            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Login l1 = new Login("Sean1980", "12345678");
            Login l2 = new Login("Doug1978", "87654321");
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            ContactInfo c1 = new ContactInfo("1234 Bob Ave.", "Wichita", "KS", "67203", "3161234567", "iamhere@whocares.gov");
            ContactInfo c2 = new ContactInfo("5678 Your St.", "Boise", "ID", "54794", "5196562356", "nowayjose@whereami.org");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }//end Main
    }//end class
}//end namespace
