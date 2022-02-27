using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {            
            Account<int> account1 = new Account<int>();
            account1.account(1251, 981361.16, "Иванов Иван Иванович"); ;

            Account<string> account2 = new Account<string>();
            account2.account("151961", 3473.41, "Петров Петр Петрович");

            account1.print();
            account2.print();
            account1.Read(out int number, out double balance, out string name);
            Console.WriteLine("Номер счета: {0}\nБаланс: {1}\nФИО владельца: {2}\n", number, balance, name);
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T Number { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }

        public void account(T number, double balance, string name)
        {
            Number = number;
            Balance = balance;
            Name = name;
        }

        public void Read(out T number, out double balance, out string name)
        {
            number = Number;
            balance = Balance;
            name = Name;
        }
        public void print()
        {
            Console.WriteLine("Номер счета: {0}\nБаланс: {1}\nФИО владельца: {2}\n", Number, Balance, Name);
        }

    }
}
