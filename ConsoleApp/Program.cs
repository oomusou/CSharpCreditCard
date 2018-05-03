using System;
using OrderLibrary;
using OrderLibrary.Bank;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 2000.0;
            var orderService = new OrderService();
            
            Console.WriteLine("刷中信卡");
            Console.WriteLine(orderService.GetPrice(Bank.ChinaTrust, price));
            
            Console.WriteLine("刷台新卡");
            Console.WriteLine(orderService.GetPrice(Bank.TaishiBank, price));
            
            Console.WriteLine("刷花旗卡");
            Console.WriteLine(orderService.GetPrice(Bank.CityBank, price));
        }
    }
}