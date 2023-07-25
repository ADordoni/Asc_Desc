using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------- EXAMPLE OF USING ---------//
            int[] array = { 5, 15, 44, 72, 105, 2 };
            foreach (int i in Order.Ascend(array))
            {
                Console.WriteLine(i);
            }
            foreach (int i in Order.Descend(array))
            {
                Console.WriteLine(i);
            }

        }        
    }
    class Order
    {        
        public static int[] Ascend(int[] array)
        {
            int backup;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j] && i < j)
                    {
                        backup = array[i];
                        array[i] = array[j];
                        array[j] = backup;
                    }
                }
            }
            return array;
        }
        public static int[] Descend(int[] array)
        {
            int backup;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j] && i < j)
                    {
                        backup = array[i];
                        array[i] = array[j];
                        array[j] = backup;
                    }
                }
            }
            return array;
        }
    }
}