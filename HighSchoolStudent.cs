using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class HighSchoolStudent : Student
    {
        private string _id;
        private string _className;
        private bool _study;
        private const byte MIN_ID_LENGHT = 5;


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


        public HighSchoolStudent(string id, string name) : base(name)
        {
            ID = id;
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
            return base.ToString() + $"ID: {ID};\nClass name: {ClassName};\nStudy: {Study1};\n";
        }
    }
}
