using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the listNumbers: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] listNumbers = new int[size];
            Console.WriteLine("Enter the list number: ");
            for (int i = 0; i < size; i++)
            {
                listNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            sort(listNumbers);
            for (int i = 0; i < listNumbers.Length; i++)
            {
                Console.Write(listNumbers[i] + " ");
            }
            Console.ReadKey();
        }
        static void sort(int[] listNumbers)
        {
            for (int i = 0; i < listNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < listNumbers.Length; j++)
                {
                    if (listNumbers[j] <= listNumbers[i]) swap(ref listNumbers[i], ref listNumbers[j]);
                }
            }
        }
        static void swap(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
