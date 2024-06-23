using System.Collections.Generic;

public class AttendanceService
{
    private readonly IAttendanceRepository _attendanceRepository;

    public AttendanceService(IAttendanceRepository attendanceRepository)
    {
        _attendanceRepository = attendanceRepository;
    }

    public void AddAttendance(Attendance attendance)
    {
        _attendanceRepository.AddAttendance(attendance);
    }

    public void OverrideAttendance(int attendanceId, Attendance attendance)
    {
        _attendanceRepository.OverrideAttendance(attendanceId, attendance);
    }

    public Attendance ReadAttendanceOfEmployeeById(int employeeId)
    {
        return _attendanceRepository.ReadAttendanceOfEmployeeById(employeeId);
    }

    public List<Attendance> GetAllAttendances()
    {
        return _attendanceRepository.GetAllAttendances();
    }
}