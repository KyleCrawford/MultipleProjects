using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int dataSize = 1000;
            int dataMax = 100;
            List<int> data = new List<int>(dataSize);
            Random r = new Random();
            for (int i = 0; i < dataSize; ++i)
                data.Add(r.Next(dataMax) + 1);
            Console.WriteLine((IsSorted(data) ? "Sorted" : "!!UNSORTED") + " List:");
            PrintList(data);
            QuickSort(data, 0, data.Count - 1);
            Console.WriteLine((IsSorted(data) ? "Sorted" : "!!UNSORTED") + " List:");
            PrintList(data);

            Console.ReadKey();

            List<string> testing = new List<string>(1000);
            testing.Add("cat");
            testing.Add("bat");
            testing.Add("eat");
            testing.Add("fat");
            testing.Add("gat");
            testing.Add("hat");
            testing.Add("bear");
            testing.Add("dog");
            testing.Add("cheese");
            testing.Add("how");
            testing.Add("long");
            testing.Add("will");
            testing.Add("this");
            testing.Add("tak");
            testing.Add("i ");
            testing.Add("wonder");
            testing.Add("argh");
            testing.Add("hurry");
            testing.Add("the");
            testing.Add("***");

            Console.WriteLine((IsSorted(testing) ? "Sorted" : "!!UNSORTED") + " List:");
            PrintList(testing);
            QuickSort(testing, 0, testing.Count - 1);
            Console.WriteLine((IsSorted(testing) ? "Sorted" : "!!UNSORTED") + " List:");
            PrintList(testing);

            Console.ReadKey();

        }

        public static void QuickSort<T>(List<T> data, int firstIndex, int lastIndex) where T : IComparable
        {
            //Recursive quicksort.
            if (lastIndex <= firstIndex) //nothing to sort
                return;
            else if (lastIndex - firstIndex == 1)
            { //exactly two items
                if (data[firstIndex].CompareTo(data[lastIndex]) > 0)
                    Swap(data, firstIndex, lastIndex);
                //if (data[firstIndex] > data[lastIndex]) //out of order
                return;
            }
            else
            {
                int key = firstIndex;
                int left = firstIndex + 1;
                int right = lastIndex;
                do
                {
                    //Find first on right that is too small
                    while (right > left && (data[right].CompareTo(data[key]) > 0))// > data[key]))
                        right--;
                    //Find first on left that is too big
                    while (left < right && (data[left].CompareTo(data[key])) <= 0)// <= data[key])) //Leave matching values on left
                        left++;
                    //If we haven't met yet, swap em
                    if (right > left)
                        Swap(data, left, right);
                }
                while (right > left); //Keep going until we meet
                                      //Finished this iteration
                                      //Special case: If key was already in correct position, no swap
                if (right == key + 1 && data[right].CompareTo(data[key]) >= 0) // >= data[key])  //Problem occurs if right ends up adjacent to key
                    right--; //Reset right so that it gets sorted again
                else //Normal state, key needs to move
                    Swap(data, key, right); //Move key into proper location
                                            //Recurse left side
                QuickSort(data, firstIndex, right - 1);
                //Recurse right side
                QuickSort(data, right + 1, lastIndex);
            }
        }


        /*
        public static void QuickSort(List<int> data, int firstIndex, int lastIndex)
        {
            //Recursive quicksort.
            if (lastIndex <= firstIndex) //nothing to sort
                return;
            else if (lastIndex - firstIndex == 1)
            { //exactly two items
                if (data[firstIndex] > data[lastIndex]) //out of order
                    Swap(data, firstIndex, lastIndex);
                return;
            }
            else
            {
                int key = firstIndex;
                int left = firstIndex + 1;
                int right = lastIndex;
                do
                {
                    //Find first on right that is too small
                    while (right > left && (data[right] > data[key]))
                        right--;
                    //Find first on left that is too big
                    while (left < right && (data[left] <= data[key])) //Leave matching values on left
                        left++;
                    //If we haven't met yet, swap em
                    if (right > left)
                        Swap(data, left, right);
                }
                while (right > left); //Keep going until we meet
                                      //Finished this iteration
                                      //Special case: If key was already in correct position, no swap
                if (right == key + 1 && data[right] >= data[key])  //Problem occurs if right ends up adjacent to key
                    right--; //Reset right so that it gets sorted again
                else //Normal state, key needs to move
                    Swap(data, key, right); //Move key into proper location
                                            //Recurse left side
                QuickSort(data, firstIndex, right - 1);
                //Recurse right side
                QuickSort(data, right + 1, lastIndex);
            }
        }
        */
        public static void Swap<T>(List<T> data, int index1, int index2)
        {
            T temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        public static void Swap(List<int> data, int index1, int index2)
        {
            int temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }

        public static void PrintList<T>(List<T> data)
        {
            foreach (T i in data)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        public static bool IsSorted<T>(List<T> data) where T : IComparable
        {
            //For debugging.  Predicate returns true if list is sorted
            for (int i = 0; i < data.Count - 1; ++i)
                if (data[i].CompareTo(data[i + 1]) > 0)
                    return false;
            return true;
        }
    }
}