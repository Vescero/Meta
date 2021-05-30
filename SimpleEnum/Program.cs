using System;

namespace SimpleEnum
{
    enum GlobalOperation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    class Program
    {
        static void Main()
        {
            Operation op = new Operation();
            op = Operation.Add;
            Console.WriteLine(op);
            op = Operation.Multiply;    // Привидение к числовому типу
            Console.WriteLine((int)op); // для вывода значения переменной
            MathOp(10, 5, Operation.Add);
            MathOp(11, 5, Operation.Multiply);
            Console.ReadKey();
        }
        /* Метод принимает два числовых аргумента и тип операции */
        static void MathOp(double x,double y,Operation operation)
        {
            double result = 0.0;
            switch (operation)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine($"Результат: {result}");
        }
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Time : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }
        /* Зачастую переменная перечисления выступает в качестве хранилища состояния,
         * в зависимости от которого производятся некоторые действия*/
        public enum Operation
        {
            Add = 1,    // Каждый следующий элемент увеличится на 1
            Substract,  // 2
            Multiply,   // 3
            Divide      // 4
        }
        enum Operation2
        {
            Add = 2,    // Можно явно указать значение всех элементов
            Substract = 4,
            Multiply = 8,
            Divide = 16
        }
        enum Color
        {
            White = 1,  // Константы перечисления могут иметь одинаковые значение
            Black = 2,  // и могут присваивать значения друг друга
            Green = 2,
            Blue = White // Blue = 1
        }      
    }
}
