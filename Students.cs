
namespace Lab6
{
    public class Students
    {
        private Student[] _students;

        /// <summary>
        /// Если параметром приходит ноль инициализируем с нулевой длиной массив 
        /// </summary>
        /// <param name="students">Элементы вставляемые в массив, наследники класса Student</param>
        public Students(params Student[] students)
        {
            if (students is not null)
            {
                _students = students;
            }
            else
            {
                _students = new Student[0];
            }
        }
        
        /// <summary>
        /// Добавляем элемент в конец массива
        /// </summary>
        /// <param name="student">Объект для добавления</param>
        /// <exception cref="FormatException"></exception>
        public void AddStudent(Student student)
        {
            if (student is null)
            {
                throw new FormatException("Incorrect person parameter.");
            }
            else
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
        }

        /// <summary>
        /// Удаление элемента массива по индексу, вернет ArgumentOutOfRangeException, если индекс не корректный 
        /// </summary>
        /// <param name="index">Индекс удаляемого объекта</param>
        public void DeleteStudent(int index)
        {
            if (index >= 0 && index < _students.Length)
            {
                Array.Copy(_students, index + 1, _students, index, _students.Length - index - 1);
                Array.Resize(ref _students, _students.Length - 1);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Обновление элемента массива по индексу, вернет ArgumentOutOfRangeException, если индекс не корректный 
        /// </summary>
        /// <param name="index">Индекс обновляемого объекта</param>
        /// <param name="student">Новый элемент</param>
        /// <exception cref="FormatException"></exception>
        public void EditStudents(uint index, Student student)
        {
            if (index >= 0 && index < _students.Length && !(student is null))
            {
                _students[index] = student;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public override string ToString()
        {
            String result = "";
            foreach (Student student in _students)
            {
                result += student + "\n";
            }
            return result;
        }

    }
}
