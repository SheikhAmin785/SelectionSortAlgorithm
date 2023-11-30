using System;

namespace SelectionSortAlgorithm
{
    class Program
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
        }
                public static void Main()
                {
                    int[] array = new int[] { 10, 35, 12, 8 };
                    Program.Sort(array);
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(" " + array[i]);
                    }


                }
            }
        }
    


        
    

       
    


