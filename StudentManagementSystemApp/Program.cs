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
   
    
}
