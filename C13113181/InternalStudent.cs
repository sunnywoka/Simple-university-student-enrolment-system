using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C13113181
{
    public class InternalStudent : Student
    {
        public InternalStudent(int id, string name)
        {
            this.id = id;
            this.name = name;
            attendanceType = new InClassAttendance();
            labType = new MasseyLab();
            AttendanceType = attendanceType.Attendance();
            LabType = labType.Lab();
        }
    }
}