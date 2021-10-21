using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Course
    {

        public string name;
        public User teacher;
        public List<User> students;
        public List<Grade> grades;

        public Course() {
            this.students = new List<User>();
            this.grades = new List<Grade>();
        }
    }
}
