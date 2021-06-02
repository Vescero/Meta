using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexsator
{
    class People
    {
        /* Класс люди содержит в себе массив из 5 объектов класса человек */
        Person[] data = new Person[5];
        /* Индексатор  определяет тип возвращаемого значения (человек) и способ доступа
         к элементам массива через параметр int index, который будет доставать их из data*/
        public Person this[int index] { get { return data[index]; } set { data[index] = value; } }
        /* Индексаторы так же можно перегружать, правила те же. Отличаться по количеству,
         типу или порядку используемых параметров.*/
        public Person this [string name]
        {
            get 
            { 
                Person person = null; 
                foreach (var p in data)
                {
                    if(p?.Name == name)
                    {
                        person = p;
                        break;
                    }
                }
                return person;
            }
        }
    }
}
