using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SortingAlgorithms
    {
        public int[] GenerateArray(int[] array)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i=0; i <= array.Length; i++)
            {
                int number = rnd.Next(0, 999);
                array[i] = number;
            }

            return array;
        }

        public int[] GenerateArray(int[] array, int min, int max)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < array.Length; i++)
            {
                int number = rnd.Next(min, max);
                array[i] = number;
            }

            return array;
        }

        public void Display(int[] array)
        {
            for(int i=0; i < array.Length; i++)
            {
                Console.Write(" "+ array[i]);
            }
        }

        public int[] BubbleSort(int[] array)
        {
            int aux;

            for(int i=0; i< array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux; 
                    }
                }
            }
            return array;
        }

        public int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;

                while ((j > 0) && (array[j - 1] > key))
                {
                    array[j] = array[j - 1];
                    j -= 1;
                }
                array[j] = key;
            }
            return array;
        }

        public int[] SelectionSort(int[] array)
        {
            int aux;
            int iMin;
            for (int i = 0; i < array.Length - 1; i++)
            {
                aux = array[i];
                iMin = i;
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < aux)
                    {
                        aux = array[j];
                        iMin = j;
                    }
                }
                
                array[iMin] = array[i];
                array[i] = aux;
            }
            
            return array;
        }

        public void MergeSort(int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);

                Merge(array, left, (mid + 1), right);
            }
        }

        private void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public void QuickSort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i] < pivot)
                {
                    i++;
                }

                while (elements[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }

    }
}

