﻿using System;

namespace laba2_2_3_
{
    public class Time
    {
        private byte hours; //поле для хранения часов, минут
        private byte minutes;

        public byte Hours //свойство для доступа к часам
        {
            get => hours; //возвращ зн поля hours
            set
            {
                if (value >= 24) throw new ArgumentOutOfRangeException("Часы должны быть в диапазоне 0-23");
                hours = value;
            }
        }

        public byte Minutes
        {
            get => minutes;
            set
            {
                if (value >= 60) throw new ArgumentOutOfRangeException("Минуты должны быть в диапазоне 0-59");
                minutes = value;
            }
        }

        //конструктор инициализации
        public Time(byte hours, byte minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}";
        }

        public Time AddMinutes(uint minutesToAdd)
        {
            int totalMinutes = hours * 60 + minutes + (int)minutesToAdd;
            byte newHours = (byte)(totalMinutes / 60 % 24);
            byte newMinutes = (byte)(totalMinutes % 60);
            return new Time(newHours, newMinutes);
        }

        public Time SubtractMinutes(uint minutesToSubtract)
        {
            int totalMinutes = (hours * 60 + minutes) - (int)minutesToSubtract;
            if (totalMinutes < 0) totalMinutes += 1440; // если отрицательное время (24 часа)
            byte newHours = (byte)(totalMinutes / 60 % 24);
            byte newMinutes = (byte)(totalMinutes % 60);
            return new Time(newHours, newMinutes);
        }

        //перегрузки операторов
        public static Time operator ++(Time time) => time.AddMinutes(1); //+1
        public static Time operator --(Time time) => time.SubtractMinutes(1); //-1
        public static explicit operator byte(Time time) => time.hours; //возвр часы
        public static implicit operator bool(Time time) => time.hours != 0 || time.minutes != 0; //время равно 00
        public static Time operator +(Time time, uint minutesToAdd) => time.AddMinutes(minutesToAdd); //+мин
        public static Time operator -(Time time, uint minutesToSubtract) => time.SubtractMinutes(minutesToSubtract); //-мин
    }
}