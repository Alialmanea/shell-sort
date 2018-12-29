using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    class Program
    {
        public static void quick_sort(int[] a, int left, int right)
        {
            int pivot = a[(left + right) / 2];
            int swap;
            int i = left, j = right;
            while (i <= j)
            {
                while (a[i] < pivot)
                    i++;
                while (a[j] > pivot)
                    j--;
                if (i <= j)
                {
                    swap = a[i];
                    a[i] = a[j];
                    a[j] = swap;

                    i++;
                    j--;
                }


                if (left < j)
                    quick_sort(a, left, j);

                if (right > i)
                    quick_sort(a, i, right);


            }
        }


        public static void show(int[] a)
        {

            for (int x = 0; x < a.Length; x++)
            {

                Console.Write("|" + a[x] + "|");

            }
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 3, 7, 4, 9, 1 };
            Console.Write("the our array befor be sorted>>>");
            for (int x = 0; x < a.Length; x++)
            {

                Console.Write("|" + a[x] + "|");

            }
            Console.WriteLine();

            //the mothod(array,left,right);
            quick_sort(a, 0, a.Length - 1);
            Console.Write("<<<<The our array after being sorted by using the quick sort algorithm>>>");
            Console.WriteLine();
            for (int x = 0; x < a.Length; x++)
            {

                Console.Write("|" + a[x] + "|");

            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("                                                          Ali Almanea</>");
            Console.ReadLine();
        }
    }
}
