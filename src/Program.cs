using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Это основная программа проекта");
            Console.WriteLine("Лабораторная работа №5");

            // Пример использования утилиты
            var result = Utils.HelloMessage();
            Console.WriteLine(result);
        }
    }
}