using Lab6;

internal class Program
{
    private static void Main(string[] args)
    {

        Student student = new HighSchoolStudent("dfghjk",5, "+380151655154", "Ivan",15,true);
        student.AttendClass("Math");
        student.Study();

        Console.WriteLine(student);
        student.Study();

        Console.WriteLine(student);


        HighSchoolStudent student1 = new HighSchoolStudent("dfg584", 11, "+380151655154", "Natasha", 16, false);

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