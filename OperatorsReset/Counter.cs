using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsReset
{
    class Counter
    {
        public int Value { get; set; }

        /* Перегрузка операторов */
        /* Сложение 2х объектов класса, возвращает новый объект данного класса в котором 
         * значения их полей будут сложены*/
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        /* Поскольку перегрузка оператора метод, поэтому его можно так же перегрузить */
        public static Counter operator + (Counter c1, int val)
        {
            return new Counter { Value = c1.Value + val };
        }
        /* Сложение 2х объектов класса, возвращает булево значение которое сравнивает 
         * какое значение в классах больше или меньше. Требуются оба!*/
        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator < (Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
        /* Инкремент, менять объекты передаваемые в качестве параметра неправильно.
         При инкременте нужно создавать новый объект, который содержит инкрементированное значение*/
        public static Counter operator ++ (Counter c1)
        {
            return new Counter { Value = c1.Value + 10 };
        }
    }

}
