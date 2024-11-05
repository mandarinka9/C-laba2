using System;
using System.Linq;

namespace Laba2
{
    public class SecondClass : FirstClass
    {
        public DateTime CreatedAt { get; } // Свойство для хранения даты создания текста

        // Конструктор времени
        public SecondClass(string text) : base(text)
        {
            CreatedAt = DateTime.Now; // Устанавливаем текущую дату и время
        }

        public int Length => Text.Length; //свойство через лямбду

        public string Vverh()
        {
            return Text.ToUpper();
        }

        public int CountGlas()
        {
            var glas = "aeiouyаеёиоуыэюя";
            return Text.ToLower().ToCharArray()
                .Where(c => char.IsLetter(c) && glas.IndexOf(c) != -1).Count(); // Фильтруем буквы и гласные

        }

        public override string ToString()
        {
            // Переопределяем ToString() для вывода информации о тексте и дате создания
            return base.ToString() + $", Дата создания: {CreatedAt}";
        }
    }
}