using Lab6;

internal class Program
{
    private static void Main(string[] args)
    {

        HighSchoolStudent student = new HighSchoolStudent("dfghjk",5, "+380151655154", "Ivan",15,true);
        HighSchoolStudent student1 = new HighSchoolStudent("dfg584", 10, "+380151655154", "Natasha", 16, false);
        HighSchoolStudent student2 = new HighSchoolStudent("df7rd84", 1, "+380151655154", "Dima", 12, true);
        HighSchoolStudent student3 = new HighSchoolStudent("dpt5584", 7, "+380151655154", "Olga", 9, false);


        Students students = new Students(student, student1);
        Console.WriteLine("\nStudents:\n" + students);

        students.AddStudent(student2);
        Console.WriteLine("\nStudents:\n" + students);

        students.DeleteStudent(0);
        Console.WriteLine("\nStudents:\n" + students);

        students.EditStudents(0, student3);
        student3.AttendClass("Math");
        student3.Study();
        Console.WriteLine("\nStudents:\n" + students);
    }
}