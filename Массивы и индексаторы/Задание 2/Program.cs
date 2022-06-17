using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Article
    {
        private string _product_name;
        private string _shop_name;
        private double _price;

        public string Product_name
        {
            get
            {
                return _product_name;
            }
        }

        public string Shop_name
        {
            get
            {
                return _shop_name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public Article(string product_name, string shop_name, double price)
        {
            _product_name = product_name;
            _shop_name = shop_name;
            _price = price;
        }

        public Article()
        {

        }
    }

    class Store : Article
    {
        private Article[] all_products;

        public void CreateMass(int count)
        {
            all_products = new Article[count];
        }
            
        public void AddArticles(int id, Article a)
        {
            all_products[id] = a;
        }

        public void ProductInfo(int index)
        {
            Console.WriteLine("Название товара: " + all_products[index].Product_name + "\nНазвание магазина: " + all_products[index].Shop_name + "\nЦена товара: " + all_products[index].Price);
        }

        public void ProductNameInfo(string name)
        {
            bool prov = true;
            for(int i = 0; i < all_products.Length; i++)
            {
                if (all_products[i].Product_name == name)
                {
                    ProductInfo(i);
                    prov = false;
                    break;
                }
            }
            if(prov)
                Console.WriteLine("Товара с таким названием нет");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store();
            Console.WriteLine("Введите количество товаров");
            int count = Convert.ToInt32(Console.ReadLine());
            st.CreateMass(count);

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите название товара");
                string prod_name = Console.ReadLine();
                Console.WriteLine("Введите название магазина");
                string shop_name = Console.ReadLine();
                Console.WriteLine("Введите название цену товара");
                double price = Convert.ToDouble(Console.ReadLine());

                Article art = new Article(prod_name, shop_name, price);
                st.AddArticles(i, art);
            }
            Console.WriteLine("Введите номер товара, чтобы отобразить информацию о нём");
            st.ProductInfo(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите название товара, чтобы отобразить информацию о нём");
            st.ProductNameInfo(Console.ReadLine());
            Console.Read();
        }
    }
}
