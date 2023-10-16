using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public abstract class Student : IStudent
    {
        private readonly string _name;
        private byte _age;
        private bool _gender;
        private const byte MAX_YEAR = 100;

        public string Name
        {
            get => _name;
            init
            {
                //Проверка не является ли переданная строка Null.
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        protected Student(string name, byte age, bool gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public byte Age
        {
            get => _age;
            set
            {
                //Проверка что переданное число не более 100(MAX_YEAR).
                if (value < MAX_YEAR)
                {
                    _age = value;
                }
                else
                {
                    throw new FormatException("Incorrect age.");
                }
            }
        }

        /// <summary>
        /// Установка и получение поля _gender(Пол).
        /// </summary>
        public bool Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public abstract void AttendClass(string className);


        public abstract void Study();

        public override string ToString()
        {
            return Gender ? $"Student:\nName: {Name};\nAge: {Age}\nGender: Man\n": $"Student:\nName: {Name};\nAge: {Age}\nGender: Woman\n";
        }

    }
}
