using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApp1
{
    public partial class TeacherForm : Form
    {
        List<User> Users = new List<User>();
        User Self = new User();
        XmlDocument xmlcourses = new XmlDocument();
        XmlDocument xmlhomework = new XmlDocument();
        Course Course = new Course();

        public TeacherForm(List<User> registeredusers, User self)
        {
            this.Users = registeredusers;
            this.Self = self;
            InitializeComponent();
        }

        public User findStudentById(int id)
        {
            foreach (User user in Users)
            {
                if (user.id == id)
                {
                    return user;
                }
            }
            return null;
                       
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            
            label_teacherinfo.Text = Self.name + " " + Self.lastname + " (" + Self.course + " )";
            loadCourses();
            foreach(User student in Course.students)
            {
                dataGridView1.Rows.Add(false, student.id, student.name, student.lastname);
            }
            statistics.Hide();
           
        } 
        


        public void loadCourses()
        {
            Course.name = Self.course;
            Course.teacher = Self;
            xmlcourses.Load("../../CourseList.xml");
            foreach (XmlNode course in xmlcourses.SelectSingleNode("Courses").ChildNodes)
            {
                try 
                {
                    if (course.SelectSingleNode("name").InnerText == Course.name)
                    { 
                        foreach(XmlNode studentid in course.SelectSingleNode("Students").ChildNodes)
                        {
                            User student = findStudentById(int.Parse(studentid.InnerText));
                                Course.students.Add(student);
                        }





                        foreach(XmlNode grade in course.SelectSingleNode("Grades").ChildNodes)
                        {
                            Grade grade1 = new Grade();
                            grade1.studentmark = int.Parse(grade.SelectSingleNode("mark").InnerText);
                            grade1.studentid = int.Parse(grade.SelectSingleNode("studentid").InnerText);
                            grade1.studentdate = grade.SelectSingleNode("date").InnerText;

                            Course.grades.Add(grade1);
                        }
                    }
                }
                catch { }
            }  
        }

        private void GetStudentStatistics_Button_Click(object sender, EventArgs e)
        {
            string chooseStudent= string.Empty;
            int SelectedStudent_id=0;
            bool found=false;
            for(int i=0; i<dataGridView1.RowCount-1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)==true)
                {
                    found = true;
                    statistics.Series.Clear();
                    SelectedStudent_id = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    chooseStudent += dataGridView1.Rows[i].Cells[2].Value.ToString() + " " + dataGridView1.Rows[i].Cells[3].Value.ToString();

                }
            }
            if (found == true)
            {
                statistics.Series.Add("Student Mark");
                statistics.Show();
                statistics.Titles[0].Text = chooseStudent;
                foreach(Grade grade in Course.grades)
                {
                    if(grade.studentid == SelectedStudent_id)
                    {
                        statistics.Series[0].Points.AddXY(grade.studentdate, grade.studentmark);
                    }
                }

            }
            else
            {
                MessageBox.Show("please select a student in DataGridView");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i=0; i<dataGridView1.RowCount-1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    for(int j=0; j< dataGridView1.RowCount-1; j++)
                    {
                        if (j != i) dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }
            }
        }

        private void button_gradeGiver_Click(object sender, EventArgs e)
        {
            int selectedstudentid = 0;
            bool found = false;
            for(int i=0; i<dataGridView1.RowCount-1; i++)
            {
                if(Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value)==true)
                {
     selectedstudentid = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    found = true;
                    
                }
            }
            if (found == true)
            {
                XmlNode grade = xmlcourses.CreateElement("grade");
                XmlNode studentid = xmlcourses.CreateElement("studentid");
                studentid.InnerText = selectedstudentid.ToString();
                grade.AppendChild(studentid);
                XmlNode date = xmlcourses.CreateElement("date");
                date.InnerText = DateTime.Now.ToString("dd/MM");
                grade.AppendChild(date);
                XmlNode mark= xmlcourses.CreateElement("mark");
                mark.InnerText = textbox_gradenum.Text;
                grade.AppendChild(mark);


                foreach(XmlNode course in xmlcourses.SelectSingleNode("Courses").ChildNodes)
                {
                    try
                    {
                        if (course.SelectSingleNode("name").InnerText == Course.name)

                            course.SelectSingleNode("Grades").AppendChild(grade);

                    }
                    catch { }

                }
                statistics.Series[0].Points.AddXY(date.InnerText, int.Parse(mark.InnerText));
                xmlcourses.Save("../../CourseList.xml");
                loadCourses();
            }
        }
      
        

        private void button_send_Click(object sender, EventArgs e)
        {
            xmlhomework.Load("../../Homework.xml");
            XmlNode homework = xmlcourses.CreateElement("homework");
            XmlNode headline = xmlcourses.CreateElement("headline");
            XmlNode description = xmlcourses.CreateElement("description");
            headline.InnerText = textBox_headline.Text;
            description.InnerText = textBox_description.Text;
            homework.AppendChild(headline);
            homework.AppendChild(description);
            xmlhomework.DocumentElement.AppendChild(homework);
            xmlhomework.Save("../../Homework.xml"); 
        }
    }
}
