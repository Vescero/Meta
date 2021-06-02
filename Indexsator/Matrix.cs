using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexsator
{
    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        /* Применение нескольких параметров*/
        public int this [int i, int j]
        {
            /* Так же как и в свойствах можно опускать блоки get set и менять им
             * модификаторы доступа private etc*/
            get { return numbers[i, j]; } set { numbers[i, j] = value; }
        }
    }
}
