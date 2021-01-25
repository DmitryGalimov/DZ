using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("привет, как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня [{DateTime.Now}] ");
        }
    }
}
