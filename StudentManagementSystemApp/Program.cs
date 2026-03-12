using System;
class StudentManagementSystem
{
    static string[] names = new string [10];
    static int [] ids = new int[10];
    static double[] grades = new double[10];
    static int studentCount = 0;

    static void Main()
    {
        bool running = true;
        
        while (running)
        {
            Console.WriteLine("\n=== Student Management System ===");
            Console.WriteLine("1. Add New Student");
            Console.WriteLine("2. View All Student");
            Console.WriteLine("3. Calculate Average Score");
            Console.WriteLine("4. Find Student by ID");
            Console.WriteLine("5. Update Student Grade");
            Console.WriteLine("6. Delete Student");
            Console.WriteLine("7. Display Statistics");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1: AddStudent();
                break;

                case 2: ViewStudents();
                break;

                case 3: CalculateAverage();
                break;

                case 4: FindStudent();
                break;

                case 5: UpdateGrade();
                break;

                case 6: DeleteStudent();
                break;

                case 7: DisplayStats();
                break;

                case 8: running = false;
                break;

                default:

                Console.WriteLine("Invalid choice!");
                break;
            }
        }
    }
   
    static void AddStudent()
    {
        Console.Write("Enter Student Name: ");
        names[studentCount] = Console.ReadLine();

        Console.Write("Enter Student ID: ");
        ids[studentCount] = int.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        grades[studentCount] = double.Parse(Console.ReadLine());

        studentCount++;

        Console.WriteLine("Student added successfully.");

    }

    static void ViewStudents()
    {
        Console.WriteLine("\nID\tName\tGrade\tStatus");

        for (int i = 0; i < studentCount; i++)
        {
            string status = grades[i] >= 60 ? "Pass" : "Fail";
            Console.WriteLine($"{ids[i]}\t{names[i]}\t{grades[i]}\t{status}");
        }
    }

    static void CalculateAverage()
    {
        double sum = 0;
        for (int i = 0; i < studentCount; i++)
        {
            sum += grades[i];
        }

        double average = sum / studentCount;
        Console.WriteLine($"Average Grade: {average:F2}");
    }

    static void FindStudent()
    {
        Console.WriteLine("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentCount; i++)
        {
            if (ids[i] == id)
            {
                Console.WriteLine($"Name: {names[i]}  Grade: {grades[i]}");
                return;
            }
        }

        Console.WriteLine("Student not found");
    }

    static void UpdateGrade()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentCount; i++)
        {
            if (ids[i] == id)
            {
                Console.Write("Enter new grade: ");
                grades[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Grade update.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentCount; i++)
        {
            if (ids[i] == id)
            {
                for (int j = i; j < studentCount - 1; j++)
                {
                    names[j] = names[j + 1];
                    ids[j] = ids[j +1];
                }

                studentCount--;

                Console.WriteLine("Student deleted.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    
}
