using System;

namespace Properties
{
    class Program
    {
        static void Main()
        {
            Person person = new();
            // Устанавливаем свойство - блок SET  и передаём значение value "Tom"
            person.Name = "Tom";
            person.Age = 16;
            // Получаем значение свойста и присваиваем его переменной - блок Get 
            string personName = person.Name;
            int personAge = person.Age;
            Console.WriteLine(personName);  // Tom
            Console.WriteLine(personAge);   // Возраст должен быть старше 17
        }
    }
}
