using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class StudentArray
    {
        private Student[] _students;

        public StudentArray()
        {
            _students = new HighSchoolStudent[0];
        }

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
        public void DeleteStudent(int index)
        {
            if (index >= 0 && index < _students.Length)
            {
                Array.Copy(_students, index + 1, _students, index, _students.Length - index - 1);
                Array.Resize(ref _students, _students.Length - 1);
            }
        }
        public void EditCommunity(uint index, Student student)
        {
            if (index >= 0 && index < Students.Length && !(student is null))
            {
                Students[index] = student;
            }
            else
            {
                throw new FormatException("Incorrect array index, or person parameter");
            }
        }
        public Student[] Students => _students;

    }
}
