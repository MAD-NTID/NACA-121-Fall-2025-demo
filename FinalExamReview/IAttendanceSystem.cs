public interface IAttendanceSystem
{
    public void LoadAttendanceFromFile(string filePath);
    public void SaveAttendanceToFile(string filePath);
    public void AddStudent(string firstName, string lastName, List<DateTime> attendanceDates);
    public void AddStudent(string firstName, string lastName, DateTime attendanceDate);
    public List<IStudent> SortStudentsByLastName();
    public List<IStudent> SelectStudentsByDateRange(DateTime fromDate, DateTime toDate);
    public Dictionary<string, IStudent> Students{get;}

}