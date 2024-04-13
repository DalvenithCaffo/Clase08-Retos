// See https://aka.ms/new-console-template for more information



using RetoClases01;


class Program
{

    static void Main()
    {
        Teacher teacher1 = new Teacher
        {
            Id = 1,
            Name = "Federico Salazar",
            Subject = "Periodismo",
            Students = new List<Student>()
        };
        Teacher teacher2 = new Teacher
        {
            Id = 2,
            Name = "Chorri Palacios",
            Subject = "Educación Física",
            Students = new List<Student>()
        };

        Student student1 = new Student
        {
            Id = 1,
            Name = "Dalvenith Caffo",
            Grade = 80.5,
            Teacher = teacher1
        };

        Student student2 = new Student
        {
            Id = 2,
            Name = "Rosalia Briceño",
            Grade = 99.5,
            Teacher = teacher2
        };
        Student student3 = new Student
        {
            Id = 3,
            Name = "Goku Sayajin",
            Grade = 70.2,
            Teacher = teacher2
        };

        teacher1.Students.Add(student1);
        teacher2.Students.Add(student2);
        teacher2.Students.Add(student3);

        Console.WriteLine(student1.PrintStudentInfo());
        Console.WriteLine($"Lista de estudiantes del profesro: {teacher2.Name}");
        foreach (Student student in teacher2.Students){
            Console.WriteLine(student.PrintStudentInfo());
        }

    }


}