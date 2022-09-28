using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Task_12_methods
    {
        public static void Main()
        {
            Task_12_methods t = new Task_12_methods();
            t.result();
        }
        public static int Add()//static method
        {
            int x = 10;
            int y = 20;
            int z = x + y;
            return z;

        }
        public void result()//instance method
        {
            int a = Add();
            Console.WriteLine("Addition is "+a);
            Console.ReadLine();

        }

    }
}
