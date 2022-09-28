using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks
{
    internal class Task_13_Add_Matrices
    {
        public static void Main()
        {
            int i, j, n;
            int[,] a = new int[50, 50];
            int[,] b = new int[50, 50];
            int[,] c= new int[50, 50];
            Console.Write("\n Addition of Two Matrices\n");
            Console.WriteLine("Size of the Matrix");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {

                    Console.Write("element - [{0},{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);

                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nFirst matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", a[i, j]);
            }
            Console.Write("\nThe Second matrix is :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", b[i, j]);
            }

            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    c[i, j] = a[i, j] + b[i, j];
            Console.Write("\nThe Addition of two matrix is : \n");
            
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", c[i, j]);
                Console.ReadLine();
            }
            Console.Write("\n\n");
            Console.ReadLine();



        }
    }
}
