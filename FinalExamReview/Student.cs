
public class Student : IStudent
{
    private string firstname;
    public string lastname;
    public List<DateTime> attendanceDates;
    public string FirstName => firstname;

    public string LastName => lastname;

    public List<DateTime> AttendanceDates => attendanceDates;
    public Student(string firstname, string lastname, List<DateTime> attendanceDates)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.attendanceDates = attendanceDates;
    }
    public void AddAttendance(DateTime date)
    {
        attendanceDates.Add(date);
    }

    public override string ToString()
    {
        return $"{firstname}, {lastname}";
    }
}