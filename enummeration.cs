using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    public enum Days
    {
        Monday=1, Tuesday=2,Wednesday=3,Thursday=4,Friday=5,Saturday=6
    }


    internal class enummeration
    {
        public static void Main()
        {
            foreach(int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine("Week days are "+i);
            foreach(string str in Enum.GetNames(typeof(Days)))
                Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
