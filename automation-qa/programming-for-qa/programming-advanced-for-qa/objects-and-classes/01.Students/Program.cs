using _01.Students;

int studentsCount = int.Parse(Console.ReadLine());

List<Student> studentList = new List<Student>();

for (int i = 0; i < studentsCount; i++)
{
    string[] input = Console.ReadLine().Split(" ");

    string firstName = input[0];
    string lastName = input[1];
    double grade = double.Parse(input[2]);

    Student student = new Student(firstName, lastName, grade);
    studentList.Add(student);
}

List<Student> sortedStudentList = studentList
                                .OrderByDescending(s => s.Grade)
                                .ToList();

foreach (Student student in sortedStudentList)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}