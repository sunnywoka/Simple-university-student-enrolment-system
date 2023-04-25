using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C13113181
{
    public abstract class Student
    {
        public string name;
        public int id;
        public IAttendanceType attendanceType;
        public ILabType labType;

        


        public string AttendanceType
        {
            get
            {
                return attendanceType.Attendance();
            }
            set
            {
            }
        }

        public string LabType
        {
            get
            {
                return labType.Lab();
            }
            set
            {
            }
        }

        public int StudentID
        {
            get
            {
                return id;
            }
            set
            {
            }
        }

        public string StudentName
        {
            get
            {
                return name;
            }
            set
            {
            }
        }
    }
}