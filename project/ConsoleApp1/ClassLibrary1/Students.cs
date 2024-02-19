using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Student : user
    {
        private List<AttendanceRecord> attendanceRecords;

        public Student()
        {
            attendanceRecords = new List<AttendanceRecord>();
        }

        public void AddAttendanceRecord(AttendanceRecord record)
        {
            attendanceRecords.Add(record);
        }

        public List<AttendanceRecord> GetAttendanceRecords()
        {
            return attendanceRecords;
        }
    }
    
    public class AttendanceRecord
    {
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {(IsPresent ? "Present" : "Absent")}";
        }
    }
}