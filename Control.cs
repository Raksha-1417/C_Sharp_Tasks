using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Control
    {
        public static void Main()
        {
            evenno();
            Console.WriteLine("Th grades are");
            Control g= new Control();
            g.grade();
             /* int num = 5;
               if (num == 5)
               {
                   Console.WriteLine("Number is 5");

               }
               else if (num < 6)
               {
                   Console.WriteLine("Number is less than 6");

               }
               else
               {
                   Console.WriteLine("Invalid");
               }*/


           }
            public static void evenno()

            {
                Console.WriteLine("Enter a Number");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even Number");

                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
                Console.ReadLine();

            }
        public void grade()
        {
            Console.WriteLine("Enter the number to check Grade");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || n > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (n >= 0 && n < 47)
            {
                Console.WriteLine("Fail");
            }
            else if (n >= 47 && n < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (n >= 60 && n < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (n >= 70 && n < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (n >= 80 && n < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (n >= 90 && n <= 100)
            {
                Console.WriteLine("A+ Grade is first");
            }
            Console.ReadLine();

        }
        }
    }

