using System;
using System.Linq;

namespace Laba2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст для главного класса:");
            string texttt = Console.ReadLine();
            FirstClass textbase = new FirstClass(texttt);

            Console.WriteLine("\nТестирование базового класса:");
            Console.WriteLine(textbase.ToString());
            Console.WriteLine(textbase.FirstAndLast());

            FirstClass copyBase = new FirstClass(textbase);
            Console.WriteLine("Копия базового класса:");
            Console.WriteLine(copyBase.ToString());

            // Тестирование дочернего класса
            Console.WriteLine("\nВведите текст для дочернего класса:");
            string secondText = Console.ReadLine();
            SecondClass sstextsecond = new SecondClass(secondText);

            Console.WriteLine("\nТестирование дочернего класса:");
            Console.WriteLine(sstextsecond.ToString());
            Console.WriteLine($"Длина строки: {sstextsecond.Length}");
            Console.WriteLine($"Строка в верхнем регистре: {sstextsecond.Vverh()}");
            Console.WriteLine($"Количество гласных: {sstextsecond.CountGlas()}");
            

            // Тестирование пустой строки
            Console.WriteLine("\nТестирование пустой строки:");
            FirstClass emptyBase = new FirstClass("");
            Console.WriteLine(emptyBase.ToString());
            Console.WriteLine(emptyBase.FirstAndLast());

            Console.ReadKey();
        }
    }
}
