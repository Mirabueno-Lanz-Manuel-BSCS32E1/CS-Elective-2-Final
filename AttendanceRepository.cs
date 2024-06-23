using System.Collections.Generic;

public class AttendanceRepository : IAttendanceRepository
{
    // Implement repository methods here
    public void AddAttendance(Attendance attendance) { /* Implementation */ }
    public void OverrideAttendance(int attendanceId, Attendance attendance) { /* Implementation */ }
    public Attendance ReadAttendanceOfEmployeeById(int employeeId) { /* Implementation */ }
    public List<Attendance> GetAllAttendances() { /* Implementation */ }
}