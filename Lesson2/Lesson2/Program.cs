using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выполнение заданий 1,2,3,5.
            Console.Write("Привет, введи номер текущего месяца, начиная отсчет с 0 ");
            int month = Convert.ToInt32(Console.ReadLine());
            string MonthNumber = "";
            switch (month)
            {
                case 0:
                    MonthNumber = "январе";
                    break;
                case 1:
                    MonthNumber = "феврале";
                    break;
                case 2:
                    MonthNumber = "марте";
                    break;
                case 3:
                    MonthNumber = "апреле";
                    break;
                case 4:
                    MonthNumber = "мае";
                    break;
                case 5:
                    MonthNumber = "июне";
                    break;
                case 6:
                    MonthNumber = "июле";
                    break;
                case 7:
                    MonthNumber = "августе";
                    break;
                case 8:
                    MonthNumber = "сентябре";
                    break;
                case 9:
                    MonthNumber = "октябре";
                    break;
                case 10:
                    MonthNumber = "ноябре";
                    break;
                case 11:
                    MonthNumber = "декабре";
                    break;

            }
            Console.WriteLine($"Хорошо, теперь я помогу тебе определить средесуточную температуру в {MonthNumber}. Для этого введи минимальную температуру за прошлые сутки: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Хорошо, введи теперь максимальную температуру: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int result = ((min + max) / 2);
            Console.WriteLine($"Итак, среднесуточная температура в {MonthNumber} составляет {result} градусов. ");
            if (result % 2 == 0)
            {
                Console.WriteLine("Температура имеет четное значение");
            }
            else
            {
                Console.WriteLine("Температура имеет нечетное значение");
            }
            if ((result !=0) && (MonthNumber == "декабре" || MonthNumber == "январе" || MonthNumber == "феврале"))
                {
                Console.WriteLine($"Дождливая зима");
            }
            else
            {
                Console.WriteLine("Холодная зима");
            }
            Console.WriteLine("Спасибо, что воспользовались нашей программой!");

            // Задание №4


            Console.WriteLine("Данная программа служит для формирования кассового чека. \n" +
                "Для начала введите название магазина: ");
                string shop = Console.ReadLine();
            Console.WriteLine("Теперь введите имя продавца: ");
                string name = Console.ReadLine();
            Console.WriteLine("Введите наименование товара №1: ");
                string product1 = Console.ReadLine();
            Console.WriteLine("Введите цену товара №1: ");
                int price1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите наименование товара №2: ");
                string product2 = Console.ReadLine();
            Console.WriteLine("Введите цену товара №2: ");
                int price2 = Convert.ToInt32(Console.ReadLine());
                int summ = (price1 + price2);
            Console.WriteLine($"{shop}\n" +
                $"____________________________________________\n" +
                $"Дата операции {DateTime.Now}\n" +
                $"Продавец {name}\n" +
                $"1. {product1}\n" +
                $"Стоимость.....................{price1} руб.\n" +
                $"2. {product2}\n" +
                $"Стоимость.....................{price2} руб.\n" +
                $"==========================================\n" +
                $"ИТОГО.........................{summ} руб.\n" +
                $"Наличными.....................{summ} руб.\n" +
                $"Спасбио за покупку!");


        }
    }
}
