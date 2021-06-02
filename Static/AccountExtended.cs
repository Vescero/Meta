using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class AccountExtended
    {
        /* Поля */
        private static decimal minSum = 100; // Минимальная сумма для вклада
        /* Свойства */
        public static decimal MinSum { get { return minSum; } set { if (value > 0) minSum = value; } }
        public decimal Sum { get; set; }    // Сумма на счёте
        public decimal Rate { get; set; }   // Процентная ставка
        /* Конструктор */
        public AccountExtended (decimal sum, decimal rate)
        {
            if (sum < minSum) throw new Exception("Недопустиммая сумма");
            Sum = sum; Rate = rate;
        }
        /* Метод */
        /* Подсчёт суммы на счете через определённый период по определенной ставке */
        public static decimal GetSum (decimal sum,decimal rate, int period)
        {
            decimal result = sum;
            for (int i=1; i<=period; i++)
            {
                result += result * rate;
            }
            return result;
        }

    }
}
