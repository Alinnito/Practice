using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        class Invoice
        {
            private int _account { get; }
            private string _customer { get; }
            private string _provider { get; }

            private string _article;
            private int _quantity;

            public string Article
            {
                get
                {
                    return _article;
                }
                set
                {
                    _article = value;
                }
            }

            public int Quantity
            {
                get
                {
                    return _quantity;
                }
                set
                {
                    _quantity = value;
                }
            }

            public Invoice(int account, string customer, string provider)
            {
                _account = account;
                _customer = customer;
                _provider = provider;
            }

            public void Cost_of_order_NDS()
            {
                Console.WriteLine("Стоимость заказа без НДС:" + _account * _quantity);
                Console.WriteLine("Стоимость заказа с НДС:" + (_account * _quantity * 0.13 + _account * _quantity));
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите покупателя: ");
            string customer = Console.ReadLine();
            Console.WriteLine("Введите поставщика: ");
            string provider = Console.ReadLine();
            Console.WriteLine("Введите стоимость товара: ");
            int account = Convert.ToInt32(Console.ReadLine());

            Invoice inv = new Invoice(account, customer, provider);

            Console.WriteLine("Введите количество товара: ");
            inv.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите артикул товара: ");
            inv.Article = Console.ReadLine();
            inv.Cost_of_order_NDS();

            Console.Read();
        }
    }
}
