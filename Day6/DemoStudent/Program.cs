using DemoStudent;


StudentList studentList = new StudentList();

bool exitMenu = false;

while (!exitMenu)
{
    Console.WriteLine("----- Menu -----");
    Console.WriteLine("1. Get All Students");
    Console.WriteLine("2. Add Student");
    Console.WriteLine("3. Find Student By ID");
    Console.WriteLine("4. Find Students By Name");
    Console.WriteLine("5. Exit");
    Console.WriteLine("----------------");

    Console.Write("Enter your choice (1-5): ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("----- All Students -----");
            List<Student> students = studentList.GetStudents();
            foreach (Student std in students)
            {
                Console.WriteLine(std.ToString());
            }
            break;
        case "2":
            Console.WriteLine("----- Add Student -----");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Student added successfully.");
            break;
        case "3":
            Console.WriteLine("----- Find Student By ID -----");
            Console.Write("Enter student ID: ");
            string id = Console.ReadLine();
            Student? foundStudent = studentList.FindById(id);
            if (foundStudent != null)
            {
                Console.WriteLine(foundStudent.ToString());
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
            break;
        case "4":
            Console.WriteLine("----- Find Students By Name -----");
            Console.Write("Enter student name: ");
            string name = Console.ReadLine()!;
            List<Student> foundStudents = studentList.FindByName(name!);
            if (foundStudents.Count > 0)
            {
                Console.WriteLine("Found Students:");
                foreach (Student std in foundStudents)
                {
                    Console.WriteLine(std);
                }
            }
            else
            {
                Console.WriteLine("No students found.");
            }
            break;
        case "5":
            exitMenu = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine();
}
