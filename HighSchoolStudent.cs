using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class HighSchoolStudent : Student
    {
        private string _id;
        private byte _mark;
        private string _contact;
        private string _className;
        private bool _study;
        private const byte MIN_ID_LENGHT = 5;
        private const byte MAX_MARK = 12;
        private const byte MIN_MARK = 1;


        public string ID
        {
            get => _id;
            set
            {
                //Проверка не является ли переданная строка Null, а также что длина ID больше или равно 5(MIN_ID_LENGHT).
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


        public string ClassName
        {
            get => _className;
            set
            {
                //Проверка не является ли переданная строка Null.
                if (!string.IsNullOrEmpty(value))
                {
                    _className = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }


        public bool Study1
        {
            get => _study;
            set => _study = value;
        }


        public HighSchoolStudent(string id, byte mark, string contact, string name, byte age, bool gender) : base(name, age, gender)
        {
            ID = id;
            Mark = mark;
            Contact = contact;
        }

        public override void AttendClass(string className)
        {
            ClassName = className;
        }

        public override void Study()
        {
            Study1 = !Study1;
        }

        public override string ToString()
        {
            return base.ToString() + $"ID: {ID};\nMark: {Mark};\nContact: {Contact}\nClass name: {ClassName};\nStudy: {Study1};\n";
        }
    }
}
