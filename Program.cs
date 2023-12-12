using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex1sort();
            //ex2();
            //ex2sort();
            ex3();
        }

        private static void ex3()
        {
            double[] array = { 1, 2, -3, 0, -5, 6, 7, 8, -9, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = Math.Pow(array[i], 2);
                }
                if (array[i] > 0)
                {
                    array[i] = array[i] / 2;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("-----------------------");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex2sort()
        {
            int[] array = { 5, 8, 7, 4, 2, 6, 7, 3, 9, 10 };
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex2()
        {
            int[] array = { 5, 8, 7, 4, 2, 6, 7, 3, 9, 10 };
            int max = array.Max();
            int min = array.Min();
            int indexMax = Array.IndexOf(array, max);
            int indexMin = Array.IndexOf(array, min);
            float sum = 0;
            float colvo = 0;
            for (int i = indexMin; i < indexMax; i++)
            {
                sum += array[i];
                colvo++;
            }
            Console.WriteLine(sum);
            Console.WriteLine("---------------------");
            float sr = sum / colvo;
            Console.WriteLine(sr);
        }

        private static void ex1sort()
        {
            int[] array = { 5, 2, 3, -4, 5, 6, 7, 8, -9, -10 };
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void ex1()
        {
            int[] array = { 5, 2, 3, -4, 5, 6, 7, 8, -9, -10 };
            List<int> list = new List<int>();
            List<int> listt = new List<int>();
            int umn = 1;
            foreach (int item in array)
            {
                if (item < 0)
                {
                    list.Add(item);
                }
                if (item > 0)
                {
                    listt.Add(item);
                }
            }
            int index1 = Array.IndexOf(array, list[0]);
            int index2 = Array.IndexOf(array, listt[listt.Count - 1]);
            for (int i = index1 + 1; i < index2; i++)
            {
                umn = umn * array[i];
            }
            Console.WriteLine(umn);
            Console.ReadKey();
        }
    }
}
