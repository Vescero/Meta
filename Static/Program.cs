using System;

namespace Static
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Account.bonus);       // 100
            Account.bonus += 200;                   // 300

            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum);   // 450

            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum); ; // 1300
            Console.WriteLine("~~~~ End of Account ~~~~");

            /* Обращение к статическим полям\методам класса без создания его объектов */
            AccountExtended.MinSum = 560;
            decimal result = AccountExtended.GetSum(1000, 0.1m, 5);
            Console.WriteLine(result);
            Console.WriteLine("~~~~ End of AccountExtended ~~~~");

            User user1 = new();
            User user2 = new();
            User user3 = new();
            User user4 = new();
            User user5 = new();

            User.DisplayCounter(); // 5

            Console.ReadKey();

        }
    }
}
