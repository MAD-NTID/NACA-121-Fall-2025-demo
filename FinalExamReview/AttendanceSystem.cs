using Newtonsoft.Json;
public class AttendanceSystem : IAttendanceSystem
{
    private Dictionary<string, IStudent> students;
    public AttendanceSystem()
    {
        students = new Dictionary<string, IStudent>();
    }
    public Dictionary<string, IStudent> Students => students;

    public void AddStudent(string firstName, string lastName, List<DateTime> attendanceDates)
    {
        foreach(DateTime date in attendanceDates)
        {
            AddStudent(firstName, lastName, date);
        }
    }
    public void AddStudent(string firstName, string lastName, DateTime attendanceDate)
    {
        string key = $"{firstName}{lastName}";
        if (!students.ContainsKey(key))
        {
            Student student = new Student(firstName, lastName, new List<DateTime>());
            students.Add(key, student);
        }
        //add the attendance in the student dictionary
        students[key].AddAttendance(attendanceDate);
    }

    public void LoadAttendanceFromFile(string filePath)
    {
        //check if file exist
        if(!File.Exists(filePath))
        {
            throw new FileNotFoundException($"not found -{filePath}");
        }
      
        //Load attendance data
        StreamReader reader = new StreamReader(filePath);
        // Skip
        reader.ReadLine();
        while(!reader.EndOfStream)
        {
            
            string line = reader.ReadLine();
            //Console.WriteLine(line);
            string[] items = line.Split(",");
            string firstname = items[0];
            string lastname = items[1];
            List<DateTime> dates = new List<DateTime>();
            for(int i = 2; i < items.Length; i++)
            {
                DateTime date = DateTime.Parse(items[i]);
                dates.Add(date);
            }
            AddStudent(firstname,lastname, dates);
        }
    }

    public void SaveAttendanceToFile(string filePath)
    {
        string jsonString = JsonConvert.SerializeObject(students);
        StreamWriter writer = new StreamWriter(filePath);
        writer.Write(jsonString);
        writer.Close();
        //Console.WriteLine($"Successfully saved to {filePath}"); 
    }

    public List<IStudent> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate)
    {
        //get only the students classes and ignore the keys from the dictionary

        List<IStudent> allStudents = students.Values.ToList();
        List<IStudent> filtered = allStudents.Where(student => student.AttendanceDates.Any(date=> date >= fromDate && date <= toDate)).ToList();
        return filtered;
    }
    public List<IStudent> SortStudentsByLastName()
    {
        //instruction asked for O(N^2) so we will use insertion sort because insertion sort is O(N^2)
        List<IStudent> allStudents = students.Values.ToList();

        //start of insertion sort algorithm
        for(int i = 1; i < allStudents.Count; i++)
        {
            IStudent key = allStudents[i];
            int j = i - 1;
            while(j > 0 && string.Compare(allStudents[j].LastName, key.LastName) > 0)
            {
                allStudents[j+1] = allStudents[j];
                j--;
            }
            allStudents[j + 1] = key;
        }
        return allStudents;
    }
}