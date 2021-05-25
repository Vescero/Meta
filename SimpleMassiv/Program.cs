using System;

namespace SimpleMassiv
{
    class Program
    {
        static void Main()
        {
            //Basic.MassForEach();
            //Basic.MassFor();
            //Basic.MassForExtra();
            //Basic.OneAndTwoDimmMassive();
            //Basic.ZubMassive();
        }
    }
    class Basic
    {
        public static void MassForEach()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)  // Последовательно извлекает элементы и только для чтения
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
        public static void MassFor()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            for (int i=0; i<numbers.Length;i++) // Альтернативный способ
            {
                Console.Write(numbers[i]);
            }
            Console.ReadKey();
        }
        public static void MassForExtra()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i<numbers.Length;i++)   // цикл For позволяет делать переходы между элемента и изменять значения
            {
                numbers[i] = numbers[i] * 2;
                Console.Write($"{numbers[i]}\t");;
            }
            Console.ReadKey();
        }
        public static void OneAndTwoDimmMassive()
        {
            int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
            foreach (int i in nums1)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            int rows = nums2.GetUpperBound(0) + 1;
            int columns = nums2.Length / rows;
            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<columns;j++)
                {
                    Console.Write($"{nums2[i,j]} \t");
                }
                Console.WriteLine();
            }
        }
        public static void ZubMassive()
        {
            int[,] numberss = new int[3, 4] { {1,2,3,4 },{ 4,5,6,7},{7,8,9,10} };

            int[][] nums = new int[3][]; // Массив одномерных массивов
            nums[0] = new int[] { 1, 2 };
            nums[1] = new int[] { 1, 2, 3 };
            nums[2] = new int[] { 1, 2, 3, 4 };
            int[][,] number = new int[3][,] // Массив двумерных массивов
            {
                new int[,] { { 1, 2 },{ 3, 4 } },
                new int[,] { { 1, 2 },{ 3, 6 } },
                new int[,] { { 1, 2 },{ 3, 5 },{ 8, 13 } }
            };

            foreach (int[] row in nums) // Перебор массива одномерных массивов
            {
                foreach (int numbers in row)
                {
                    Console.Write($"{numbers} \t");
                }
                Console.WriteLine();
            }

            for(int i = 0; i < nums.Length; i++)    // Перебор массива одномерных массивов
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write($"{nums[i][j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();  
        }
    }
    class Extra
    {

    }
}
