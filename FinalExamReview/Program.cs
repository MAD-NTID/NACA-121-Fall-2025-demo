AttendanceSystem attendanceSystem = new AttendanceSystem();

String[] menus =
{
    "Load attendance from file",
    "Sort students by last name",
    "Save attendance data to file",
    "Select students by data range",
    "Exit"
};

bool exit = false;
while(!exit)
{
    for(int i = 0; i <menus.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {menus[i]}");
    }

    Console.Write("Choice: ");
    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.WriteLine("Loading");
            Console.Write("Enter the load data: ");
            string file = Console.ReadLine();
            attendanceSystem.LoadAttendanceFromFile(file);
            Console.WriteLine("Attendance data loaded sucessfully");
            break;
        case "2":
                Console.WriteLine("Students sorted by last name: ");
                List<IStudent> students = attendanceSystem.SortStudentsByLastName();
                for(int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine(students[i]);
                }
            break;
        case "3":
            Console.WriteLine("Enter the file path to save attendance data to: ");
            file = Console.ReadLine();
            attendanceSystem.SaveAttendanceToFile(file);
            Console.WriteLine("Attendance data saved successfully");
            break;
        case "4":
            Console.Write("Enter the start date: ");
            DateTime fromDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter  the end date: ");
            DateTime to = DateTime.Parse(Console.ReadLine());
            students = attendanceSystem.SelectStudentsByDateRange(fromDate, to);
            foreach(IStudent student in students)
            {
                Console.WriteLine(student);
            }
        
            break;
        case "5":
            Console.WriteLine("Thank you for using this system!\nGoodbye!");
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please choose between 1-5 only");    
            break;
    }
    
}
