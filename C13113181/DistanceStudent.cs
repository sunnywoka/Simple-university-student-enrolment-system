using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C13113181
{
    public class DistanceStudent : Student
    {
        public DistanceStudent(int id, string name)
        {
            this.id = id;
            this.name = name;
            attendanceType = new OnLineAttendance();
            labType = new CloudLab();
            AttendanceType = attendanceType.Attendance();
            LabType = labType.Lab();
        }
    }
}