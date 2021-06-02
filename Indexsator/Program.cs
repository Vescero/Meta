using System;

namespace Indexsator
{
    class Program
    {
        static void Main()
        {
            /* Теперь можно работать с объектом люди как с набором объектов человек */
            People people = new People();
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };
            Person tom = people[0];
            Console.WriteLine(tom?.Name);   // Tom
            Console.WriteLine(people["Bob"].Name);  // bob
            Console.WriteLine("~~~~ End of People class ~~~~");

            User jeff = new();
            jeff["name"] = "Jeff";
            jeff["email"] = "jeffkvilvskiy@gmail.by";
            Console.WriteLine(jeff["name"]);    // Mr/Ms. Jeff

            Console.ReadKey();

            /* Для определения индексатора используются 2 индекса */
            Matrix matrix = new Matrix();
            Console.WriteLine(matrix[0,0]);
            matrix[0, 0] = 111;
            Console.WriteLine(matrix[0,0]);
        }
    }
}
