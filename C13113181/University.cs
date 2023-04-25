using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C13113181
{
    public sealed class University
    {
        private string _name;
        private static University _myUniversity;
        private bool legalInstance;
        private List<Student> _listStudent;

        private University()
        {
            if (_myUniversity == null)
            {
                _myUniversity = this;
                _name = "Massey University";
                legalInstance = true;
                _listStudent = new List<Student>();

            }
            else
            {
                legalInstance = false;
            }


        }

        public List<Student> myStudentList
        {
            get
            {
                return _listStudent;
            }
            set
            {
            }
        }

        public static University getUniversity()
        {
            return new University();
        }

        public string showDetail()
        {
            if (legalInstance)
            {
                return _name;
            }
            else
            {
                throw new Exception("Null object");
            }
        }

        public void AddStudent(Student student)
        {
            _listStudent.Add(student);
        }
    }
}