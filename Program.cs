using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            
            (string product, double amount, int quantity) taco = ("tacos", 12.45, 6);
            transactions.Add(taco);
            (string product, double amount, int quantity) poncho = ("ponchos", 2, 1);
            transactions.Add(poncho);
            (string product, double amount, int quantity) avocado = ("avocados", 27.04, 3);
            transactions.Add(avocado);
            (string product, double amount, int quantity) apple = ("apples", 4.43, 11);
            transactions.Add(apple);
            //(string product, double amount, int quantity) butt = ("butts", 700, 1);
            transactions.Add(("butts", 700, 1));

            int quant = 0;
            double amt = 0;
            double revenue = 0;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                quant = t.quantity + quant;
                amt = amt + t.amount;
                revenue = t.quantity * t.amount + revenue;
            }

            Console.WriteLine($"Items sold today: {quant}");
            Console.WriteLine($"Total revenue: ${revenue}");
        }
    }
}
