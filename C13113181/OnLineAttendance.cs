using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C13113181
{
    public class OnLineAttendance : IAttendanceType
    {
        public string Attendance()
        {
            return "On-line";
        }
    }
}