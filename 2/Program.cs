using System;

namespace laba2_2_3_
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите часы (0-23):");
                byte hours = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Введите минуты (0-59):");
                byte minutes = Convert.ToByte(Console.ReadLine());

                Time time = new Time(hours, minutes);
                Console.WriteLine($"Исходное время: {time}");

                Console.WriteLine("Введите количество минут для добавления:");
                uint minutesToAdd = Convert.ToUInt32(Console.ReadLine());
                Time newTime = time + minutesToAdd;
                Console.WriteLine($"Время после добавления минут: {newTime}");

                Time incrementedTime = time;
                Time decrementedTime = time;

                Console.WriteLine($"Время после инкремента: {++incrementedTime}");
                Console.WriteLine($"Время после декремента: {--decrementedTime}");

                byte hoursOnly = (byte)time;
                Console.WriteLine($"Часы: {hoursOnly}");

                bool isNonZero = time;
                Console.WriteLine($"Нулевое ли время?: {isNonZero}");

                Console.WriteLine("Введите количество минут для вычитания:");
                uint minutesToSubtract = Convert.ToUInt32(Console.ReadLine());
                Time subtractedTime = time - minutesToSubtract;
                Console.WriteLine($"Время после вычитания минут: {subtractedTime}");

                Console.WriteLine("Введите количество минут для сложения:");
                uint minutesToAddBinary = Convert.ToUInt32(Console.ReadLine());
                Time addedTime = time + minutesToAddBinary;
                Console.WriteLine($"Время после добавления минут: {addedTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}