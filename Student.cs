
namespace Lab6
{
    public abstract class Student : IStudent
    {
        private readonly string _name;
        private byte _age;
        private bool _gender;
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

        public abstract void AttendClass(string className);


        public abstract void Study();

        public override string ToString()
        {
            return Gender ? $"Student:\nName: {Name};\nAge: {Age}\nGender: Man\n" : $"Student:\nName: {Name};\nAge: {Age}\nGender: Woman\n";
        }

    }
}
