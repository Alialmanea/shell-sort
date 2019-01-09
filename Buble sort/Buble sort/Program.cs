using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{

    class Program
    {

        //The mathod of bubble sorting



        public static double bubble_sort(int[] array)
        {

            double timeofbubble_sort;
            Stopwatch time = new Stopwatch();
            time.Start();
            int temp;



            for (int i = 0; i < array.Length; i++)

            {

                for (int j = i + 1; j < array.Length; j++)

                {

                    if (array[i] > array[j])

                    {

                        temp = array[i];



                        array[i] = array[j];



                        array[j] = temp;

                    }

                }

            }

            Console.WriteLine();

            Console.WriteLine();



             Console.WriteLine("the Random array after the  buble sorting");

             foreach (var elment in array)

             {

                 Console.Write(elment + ",");





             }

            time.Stop();

            timeofbubble_sort = time.Elapsed.TotalMilliseconds;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("      \t     The time taken for bubble_sort process :" + time.Elapsed);


            return timeofbubble_sort;



        }






        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            time.Start();

            int[] arry = new int[10];
        


            Random rnd = new Random();



            for (int i = 0; i < arry.Length - 1; i++)
            {



                arry[i] = rnd.Next(1, 100);

            }



             Console.WriteLine("The Random array without sorting: ");



             for (int i = 0; i < arry.Length; i++)
             {



                 Console.Write(arry[i] + ",");



             }





            double timeofbubble_sort = bubble_sort(arry);



            time.Stop();



            double[] timer = new double[1];

            timer[0] = timeofbubble_sort;

           



            Array.Sort(timer);



            Console.WriteLine();

            Console.WriteLine();



           

             if (timer[0] == timeofbubble_sort)
                Console.WriteLine("*******The big o of bubble sorting is n^2*******");







            Console.WriteLine();

            Console.WriteLine("                                              Ali Rashad</>");

            Console.ReadLine();

        }

    }

}