using Lab6;

internal class Program
{
    private static void Main(string[] args)
    {

        Student student = new HighSchoolStudent("dfghjk", "Asas");
        student.AttendClass("Math");
        student.Study();
        Console.WriteLine(student);
        student.Study();
        Console.WriteLine(student);
        HighSchoolStudent student1 = new HighSchoolStudent("hllkljk","ubhjbkjb");
        Console.WriteLine(student1);
        StudentArray array = new StudentArray();
        array.AddStudent(student);
        array.AddStudent(student1);
        Console.WriteLine("/**********************************************************\\");
        foreach (var community in array.Students)
        {
            Console.WriteLine(community);
        }
    }
}