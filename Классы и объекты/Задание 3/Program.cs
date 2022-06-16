using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        class Converter
        {
            private double _rub;
            private double _usd;
            private double _eur;
            
            public Converter(double usd, double eur, double rub)
            {
                _rub = rub;
                _usd = eur;
                _eur = eur;
            }


            public double ConvertToGrivna(string valuta)
            {
                valuta = valuta.ToLower().Trim();
                switch (valuta)
                {
                    case "rub":
                        return _rub * 0.52;
                    case "usd":
                        return _usd * 29.54;
                    case "eur":
                        return _eur * 30.83;
                    default:
                        return 0;
                }
            }

            public double ConvertFromGrivna(double grivna, string valuta)
            {
                valuta = valuta.ToLower().Trim();
                switch (valuta)
                {
                    case "rub":
                        return grivna * 1.92;
                    case "usd":
                        return grivna * 0.034;
                    case "eur":
                        return grivna * 0.032;
                    default:
                        return 0;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму в рублях");
            double rub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сумму в долларах");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сумму в евро");
            double eur = Convert.ToDouble(Console.ReadLine());

            Converter conv = new Converter(usd, eur, rub);
            Console.WriteLine("Если хотите перевести из гривны в одну из валют, введите \"1\"\nЕсли хотите перевести одну из валют в гривны, введите \"2\"");
            string res = Console.ReadLine();
            while (res == "1" || res == "2")
            {
                if(res == "1")
                {
                    Console.WriteLine("Введите количество гривен");
                    double gr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("В какую валюту хотите перевести? (Введите rub, usd или eur)");
                    Console.WriteLine(conv.ConvertFromGrivna(gr, Console.ReadLine()));
                }
                if (res == "2")
                {
                    Console.WriteLine("Какую валюту хотите перевести в гривны? (Введите rub, usd или eur)");
                    Console.WriteLine(conv.ConvertToGrivna(Console.ReadLine()));
                }
                Console.WriteLine("Если хотите перевести из гривны в одну из валют, введите \"1\"\nЕсли хотите перевести одну из валют в гривны, введите \"2\"");
                res = Console.ReadLine();
            }
        }
    }
}
