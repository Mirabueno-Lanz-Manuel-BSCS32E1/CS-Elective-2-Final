using System.Collections.Generic;

public interface IAttendanceRepository
{
    void AddAttendance(Attendance attendance);
    void OverrideAttendance(int attendanceId, Attendance attendance);
    Attendance ReadAttendanceOfEmployeeById(int employeeId);
    List<Attendance> GetAllAttendances();
}