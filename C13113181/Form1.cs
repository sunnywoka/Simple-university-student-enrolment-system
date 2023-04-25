using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C13113181
{
    public partial class Form1 : Form
    {
        University _university;
        public Form1()
        {
            InitializeComponent();
            _university = University.getUniversity();
            Student one = new InternalStudent(111, "Jack");
            Student two = new InternalStudent(222, "Jackie");
            Student three = new DistanceStudent(333, "Sam");
            Student four = new DistanceStudent(444, "Lily");

            _university.AddStudent(one);
            _university.AddStudent(two);
            _university.AddStudent(three);
            _university.AddStudent(four);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _university.showDetail();
            dataGridView1.DataSource = _university.myStudentList;
        }

        
    }
}
