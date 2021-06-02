using System;

namespace OperatorsReset
{
    class Program
    {
        static void Main()
        {
            Counter c1 = new Counter() { Value = 23 };
            Counter c2 = new Counter() { Value = 45 };

            /* По умолнчаю произвести данные вычисления невозможно, поскольку используются
             * для сравнения 2 класса а не значения их полей для этого требуется перегрузка
             операторов.*/
            bool result = c1 > c2;
            Console.WriteLine(result);      // false
            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Value);    // 68
            /* Перегруженный метод, перегруженного оператора */
            Counter c4 = c1 + 27;
            Console.WriteLine(c4.Value);    // 50

            Counter c5 = new Counter() { Value = 10 };
            Console.WriteLine($"{c5.Value}");       // 10
            Console.WriteLine($"{(++c5).Value}");   //20
            Console.WriteLine($"{c5.Value}");       //20

            State aragon = new State() { Area = 1000, Population = 1000 };
            State kastilia = new State() { Area = 1500, Population = 2500 };
            State spain = aragon + kastilia;
            Console.WriteLine($"{spain.Area} {spain.Population}");
            //bool isGreater = state1 > state1;
            if (aragon > kastilia)
            {
                Console.WriteLine("aragon bigger");
            }
            else Console.WriteLine("kastilia bigger");


            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);
        }
    }

    class Bread
    {
        public int Weight { get; set; } // Масса
        public static Sandwich operator +(Bread bread, Butter butter)
        {
            return new Sandwich { Weight = bread.Weight + butter.Weight };
        }
    }
    class Butter
    {
        public int Weight { get; set; } // Масса
    }
    class Sandwich
    {
        public int Weight { get; set; } // Масса
    }
}
