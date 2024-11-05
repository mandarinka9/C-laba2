using System;


namespace Laba2
{
    public partial class FirstClass
    {
        public string Text { get; set; } //позволяет читать зн свойства, устанавливать зн св

        // Конструктор с параметром и проверкой на пустую строку
        public FirstClass(string text)
        {
            Text = text ?? string.Empty;
        }

        // Конструктор копирования
        public FirstClass(FirstClass other)
        {
            Text = other?.Text ?? string.Empty;
        }

        // Метод для создания строки из первого и последнего символа
        public string FirstAndLast()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return string.Empty;

            return $"{Text[0]}{Text[Text.Length - 1]}";
        }

        // Переопределение ToString()
        public override string ToString()
        {
            return $"Text: {Text}";
        }
    }
}
