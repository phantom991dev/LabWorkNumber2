using System;

namespace LabWorkNumber4
{
    class Program
    {
        static void Main(string[] args)
        { 
            string text = "1 - пример со знаком X \n" +
                "2 - пример со знаком Y \n" +
                "3 - пример с цифрами (без знаков X и Y) \n";

            Console.Write(text + "Введите цифру 1,2,3 - ");
            int result = Convert.ToInt32(Console.ReadLine());

            switch(result)
            {
                case 1: { Console.WriteLine("Пример со знаком X - (z = 1 - x/2 + x^2/6 - x^3/24 + x^4/120)"); break; }
                case 2: { Console.WriteLine("Пример со знаком Y - (z = 1 - y/2 + y^2/6 - y^3/24 + y^4/120)"); break; }
                case 3: { Console.WriteLine("Пример с цифрами - (z = 1 - 2 + 2/6 - 3/24 + 4/120)"); break; }
                default: { Console.WriteLine("Неверное значение"); break; }
            }

            //z = 1 - x / 2 + y ^ 2 / 6 - x ^ 3 / 24 + y ^ 4 / 120
            }
        }
    }
