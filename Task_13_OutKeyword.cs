using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Task_13_OutKeyword
    {
        public static void Main()
        {
            int id;
            string name;
            string dep;
            Student(out id, out name, out dep);
            Console.WriteLine("Student ID is " +id);
            Console.WriteLine("Student ID is " + name);
            Console.WriteLine("Student Department is " + dep);
            Console.ReadLine();
        }
        public static void Student(out int sid, out string sname, out string sdep)
        {
            sid = 13146;
            sname = "Raksha R Kademani";
            sdep = "Computer Science and Engineering";
        }
    }
}
