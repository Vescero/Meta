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
            //Basic.PositiveNumbers();
            //Basic.MassInverse();
            Extra.OutputMass();
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
        public static void PositiveNumbers()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach (int number in numbers)
            {
                if (number>0)
                {
                    result++;
                    Console.Write($"{number} \t");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine($"Число элементов больше 0: {result}");
            Console.ReadKey();
        }
        public static void MassInverse()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 5, 6, 7, 8 };
            int n = numbers.Length;
            int k = n/2;
            int temp;
            for (int i=0;i<k;i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i}\t");
            }
        }
    }
    class Extra
    {
        public static void OutputMass()
        {
            int[,,] mas = { { { 1, 2},{ 3, 4 } },
                            { { 4, 5},{ 6, 7} },
                            { { 7, 8},{ 9, 10} },
                            { { 10, 11},{12, 13} }
            };
            Console.Write("{");
            for (int rows = 0 ; rows<mas.GetLength(0); rows++)
            {
                Console.Write("{");
                for (int columns=0; columns<mas.GetLength(1); columns++)
                {
                    Console.Write("{ ");
                    for (int dimension=0; dimension<mas.GetLength(2);dimension++)
                    {
                        Console.Write(mas[rows,columns,dimension] + ",");
                    }
                    Console.Write("\b },");
                }
                Console.Write("\b},");
            }
            Console.Write("\b}");
            Console.ReadKey();
        }
    }
}
