using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shell_sort
{
    class Program
    {
       
        public static void showing(int[] a)  //showing what is going in there!
        {
            for (int x = 0; x < a.Length; x++)
            {

                Console.Write("[" + a[x] + "]");
            }

            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int i, j, increment;
            int key;

            int[] a = new int[10];
            Random rnd = new Random();

            Console.Write("The our array>>>");

            for (int x = 0; x < a.Length; x++) //The our array with random numbers
            {
                a[x] = rnd.Next(0, 20);
                Console.Write("[" + a[x] + "]");

            }

            Console.WriteLine();
            Console.WriteLine();


            increment = a.Length / 2; //increment!

            while (increment != 0)
            {
                i = increment;


                while (i < a.Length)
                {
                    key = a[i];//geting the the item 
                    j = i - increment;//geting the item which will comaper with it

                    while (j >= 0 && a[j] > key) //compuer between them 
                    {
                        a[j + increment] = a[j];    //changing the places
                        j = j - increment;

                    }

                    a[j + increment] = key;
                    i++;
                    showing(a);  //showing what is goning in here
                }

                increment = increment / 2; // The new increment value 

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(">>> The array After be sorted by The Sell sort <<<");

            for (int x = 0; x < a.Length; x++) //showing the array  after being sorted (*&*) (*&*) (*&*)
            {

                Console.Write("[" + a[x] + "]");
            }


            Console.WriteLine("                                                   Ali Almanea </>");
            Console.ReadLine();

        }
    }
}
