using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 1, 2, 3, 4, 5 };
            //Exercise1(myArray);
            //Exercise1b(myArray);


            var myStudents = new Students();
            myStudents.AddName("Alie");
            myStudents.AddName("Ingrid");
            myStudents.AddName("Samual");

            foreach (string name in myStudents)
            {
                Console.WriteLine(name);
            }


            Console.ReadLine();
        }

        static void Exercise1(int[] myArray)
        {
            int[] newArray = new int[5];
            int length = myArray.Length;
            int product = 1;

            for (int i = 0; i < length; i++)
            {
                product = 1;
                for (int j = 0; j < length; j++)
                {
                    if (j == i) continue;
                    product = product * myArray[j];
                }
                newArray[i] = product;
            }
        }

        static void Exercise1b(int[] myArray)
        {
            int product = 1;
            int[] newArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                product = product * myArray[i];
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = product/myArray[i];
            }

        }
    }
}
