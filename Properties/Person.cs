using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
        string name;
        int age;
        public int Age
        {
            get { return age; }
            set { if (value < 18) { Console.WriteLine("Возраст должен быть больше 17"); } }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
