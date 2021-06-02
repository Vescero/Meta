using System;

namespace NullOperator
{
    class Program
    {
        static void Main()
        {
            /* ?? null объеденение. Приминяется для типов которые могут принимать null
             * если операнд null подставляет значение. Если оператор уже имеет значение
             ничего не происходит*/
            object x = null;
            object y = x ?? 100; // 100 так как х равен null

            /* Оператор условного null */
            User user = new();
            //Console.WriteLine(user.Phone.Company.Name);
            /* Вызывает ошибку поскольку свойства неопределенны. В это случае нужно устроить
             * проверку на null*/
            if (user != null && user.Phone != null && user.Phone.Company != null)
            { 
            string companyName = user.Phone.Company.Name;
            Console.WriteLine(companyName); // " "
            }
            /* Можно её упростить так же добавив null объеденение и установить значение 
             * по умолчанию если значения будут null*/
            string companyName2 = user?.Phone?.Company?.Name ?? "Не установленно";
            Console.WriteLine(companyName2);    // Не установленно
        }
    }

    class User
    {
        public Phone Phone { get; set; }
    }
    class Phone
    {
        public Company Company { get; set; }
    }
    class Company
    {
        public string Name { get; set; }
    }
}
