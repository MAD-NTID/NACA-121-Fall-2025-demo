public interface IStudent
{
    public void AddAttendance(DateTime date);
    public string FirstName { get;}
    public string LastName { get;}
    public List<DateTime> AttendanceDates { get;}
}