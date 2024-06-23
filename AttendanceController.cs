using AttendanceMonitoring.Domain;
using AttendanceMonitoring.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class AttendanceController : ControllerBase
{
    private readonly AttendanceService _attendanceService;

    public AttendanceController(AttendanceService attendanceService)
    {
        _attendanceService = attendanceService;
    }

    [HttpPost]
    public IActionResult AddAttendance(Attendance attendance)
    {
        _attendanceService.AddAttendance(attendance);
        return Ok();
    }

    [HttpGet("{employeeId}")]
    public IActionResult GetAttendanceByEmployeeId(int employeeId)
    {
        var attendance = _attendanceService.ReadAttendanceOfEmployeeById(employeeId);
        return attendance != null ? Ok(attendance) : NotFound();
    }

    [HttpGet]
    public IActionResult GetAllAttendances()
    {
        var attendances = _attendanceService.GetAllAttendances();
        return Ok(attendances);
    }
}
