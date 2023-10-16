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

        protected Student(string name)
        {
            Name = name;
        }

        public abstract void AttendClass(string className);


        public abstract void Study();

        public override string ToString()
        {
            return $"Student:\n{Name};\n";
        }

    }
}
