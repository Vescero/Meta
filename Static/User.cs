using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    /* Статические классы объявляются с модификатором static и могут содержать только 
     * статические поля, свойства и методы. Создание объектов класса невозможно*/
     class User
    {
        private static int couter = 0;

        /* Статический конструктор выполняется только один раз, можно использовать для
         инициализации статических данных или действий что выполняются лишь раз*/
        static User ()  
        {
            Console.WriteLine("Создан первый пользователь");
            couter++;
        }

        public static void DisplayCounter()
        {
            Console.WriteLine($"Создано {couter} объектов User");
        }
    }
}
