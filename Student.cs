
namespace Lab6
{
    public abstract class Student : IStudent
    {
        private readonly string _name;
        private byte _age;
        private bool _gender;
        private string _className;
        private bool _study;
        private const byte MAX_YEAR = 100;


        protected Student(string name, byte age, bool gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        /// <summary>
        /// Свойство имя ученика, возвращает Incorrect name, если пытаемся присвоить пустую строку или строку с одним символом.
        /// </summary>
        public string Name
        {
            get => _name;
            init
            {
                string newValue = value.Trim();
                if (!string.IsNullOrEmpty(value) && newValue.Length > 1)
                {
                    _name = newValue;
                }
                else
                {
                    throw new FormatException("Incorrect name.");
                }
            }
        }

        /// <summary>
        /// Свойство возраст ученика, возвращает Incorrect age, если пытаемся присвоить число более 100(MAX_YEAR).
        /// </summary>
        public byte Age
        {
            get => _age;
            set
            {
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
        /// Свойство пол ученика.
        /// </summary>
        public bool Gender
        {
            get => _gender;
            set => _gender = value;
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
        public void AttendClass(string className)
        {
            ClassName = className;
        }

        /// <summary>
        /// Метод изменяющий свойство состояния ученика(сейчас учится true, нет false).
        /// </summary>
        public void Study()
        {
            Study1 = !Study1;
        }

        public override string ToString()
        {
            return Gender ? $"Student:\nName: {Name};\nAge: {Age}\nGender: Man\nClass name: {ClassName};\nStudy: {Study1};\n" : $"Student:\nName: {Name};\nAge: {Age}\nGender: Woman\nClass name: {ClassName};\nStudy: {Study1};\n";
        }

    }
}
