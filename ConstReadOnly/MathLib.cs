using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadOnly
{
    class MathLib
    {
        /* Константу нельзья опеределить с модификатором static вэ том нет смысла
         потому что значение константы инициализируется при определении, изменить его 
        нельзя и доступ к константе предоставляется при указании класса. */
        public const double PI = 3.14;
        public const double E = 2.81;
        /* Поле только для чтения можно инициализировать либо сразу при объявлении
         * либо в конструкторе. Изминение в методах или в самой программе невозможно*/
        public readonly double K = 23;
        public MathLib() { }
        public MathLib (double k)
        {
            K = k;  // Конструктор для поля только для чтения
        }

        public double GetCircleArea (double radius)
        {
            /* Константу можно обьявлять и в методе */
            const double Pi = 3.14;
            return Pi * radius * radius;
        }
    }
}
