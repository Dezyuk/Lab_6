﻿using System.Text.RegularExpressions;

namespace Lab6
{
    public class HighSchoolStudent : Student, IStudent
    {
        private string _id;
        private byte _mark;
        private string _contact;
        private string _className;
        private bool _study;
        private const byte MIN_ID_LENGHT = 5;
        private const byte MAX_MARK = 12;
        private const byte MIN_MARK = 1;


        public HighSchoolStudent(string id, byte mark, string contact, string name, byte age, bool gender) : base(name, age, gender)
        {
            ID = id;
            Mark = mark;
            Contact = contact;
        }

        /// <summary>
        /// Свойство ID ученика, возвращает Incorrect id, если пытаемся присвоить пустую строку или строку длиной менее 5 (MIN_ID_LENGHT).
        /// </summary>
        public string ID
        {
            get => _id;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= MIN_ID_LENGHT)
                {
                    _id = (value.ToUpper()).Trim();
                }
                else
                {
                    throw new FormatException("Incorrect id.");
                }
            }
        }

        /// <summary>
        /// Свойство оценка ученика, возвращает Incorrect mark, если пытаемся присвоить число меньше 1 или больше 12.
        /// </summary>
        public byte Mark
        {
            get => _mark;
            set
            {
                //Проверка что переданное значение больше либо равно 1(MIN_MARK) и меньше либо равно 12(MAX_MARK).
                if (value >= MIN_MARK && value <= MAX_MARK)
                {
                    _mark = value;
                }
                else
                {
                    throw new FormatException("Incorrect mark.");
                }
            }
        }

        /// <summary>
        /// Свойство номер телефона ученика, возвращает Incorrect phone number, если пытаемся присвоить  пустую строку или строку не в формате +***********.
        /// </summary>
        public string Contact
        {
            get => _contact;
            set
            {
                //Проверка не является ли переданная строка Null, а также на то что переданная строка передана в формате +************.
                if ((!string.IsNullOrEmpty(value)) && (Regex.IsMatch(value, @"^\+\d{12}$")))
                {
                    _contact = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect phone number");
                }
            }
        }

        /// <summary>
        /// Свойство имя класса в котором находится ученик, возвращает Incorrect class name, если пытаемся присвоить пустую строку или строку с одним символом.
        /// </summary>
        private string ClassName
        {
            get => _className;
            set
            {
                string newValue = value.Trim();
                if (!string.IsNullOrEmpty(value) && newValue.Length > 1)
                {
                    _className = newValue;
                }
                else
                {
                    throw new FormatException("Incorrect class name.");
                }
            }

        }

        /// <summary>
        /// Свойство состояния ученика(сейчас учится true, нет false).
        /// </summary>
        public bool Study1
        {
            get => _study;
            set => _study = value;
        }

        /// <summary>
        /// Метод изменяющий свойство имя класса в котором находится ученик.
        /// </summary>
        public override void AttendClass(string className)
        {
            ClassName = className;
        }

        /// <summary>
        /// Метод изменяющий свойство состояния ученика(сейчас учится true, нет false).
        /// </summary>
        public override void Study()
        {
            Study1 = !Study1;
        }
        public override string ToString()
        {
            return base.ToString() + $"ID: {ID};\nMark: {Mark};\nContact: {Contact};\nClass name: {ClassName};\nStudy: {Study1};\n";
        }
    }
}
