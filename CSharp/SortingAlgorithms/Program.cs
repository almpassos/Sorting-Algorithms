using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];

            SortingAlgorithms sorting = new SortingAlgorithms();

            myArray = sorting.GenerateArray(myArray, 0, 99);

            Console.WriteLine("Unsort Array: ");
            sorting.Display(myArray);
            Console.WriteLine("\n");
            Console.WriteLine("Sorting Array using BUBBLE SORT: ");
            sorting.BubbleSort(myArray);
            sorting.Display(myArray);
            Console.WriteLine("\n"); Console.WriteLine("\n");

            myArray = sorting.GenerateArray(myArray, 0, 99);

            Console.WriteLine("Unsort Array: ");
            sorting.Display(myArray);
            Console.WriteLine("\n");
            Console.WriteLine("Sorting Array using INSERTION SORT: ");
            sorting.InsertionSort(myArray);
            sorting.Display(myArray);
            Console.WriteLine("\n"); Console.WriteLine("\n");

            myArray = sorting.GenerateArray(myArray, 0, 99);

            Console.WriteLine("Unsort Array: ");
            sorting.Display(myArray);
            Console.WriteLine("\n");
            Console.WriteLine("Sorting Array using SELECTION SORT: ");
            sorting.SelectionSort(myArray);
            sorting.Display(myArray);
            Console.WriteLine("\n"); Console.WriteLine("\n");

            myArray = sorting.GenerateArray(myArray, 0, 99);

            Console.WriteLine("Unsort Array: ");
            sorting.Display(myArray);
            Console.WriteLine("\n");
            Console.WriteLine("Sorting Array using MERGE SORT: ");
            sorting.MergeSort(myArray, 0, myArray.Length - 1);
            sorting.Display(myArray);
            Console.WriteLine("\n"); Console.WriteLine("\n"); 

            myArray = sorting.GenerateArray(myArray, 0, 99);

            Console.WriteLine("Unsort Array: ");
            sorting.Display(myArray);
            Console.WriteLine("\n");
            Console.WriteLine("Sorting Array using Quick SORT: ");
            sorting.QuickSort(myArray, 0, myArray.Length - 1);
            sorting.Display(myArray);
            Console.WriteLine("\n"); Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
