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
    public partial class Form1 : Form
    {
        XmlDocument xmlauth = new XmlDocument();
        
        List<User> registeredUsers = new List<User>();
        XmlDocument xmlcourses = new XmlDocument();
        int lastId = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void loadRegisteredUsers()
        { 
            xmlauth.Load("../../UserList.xml");
            xmlcourses.Load("../../CourseList.xml");
            foreach (XmlNode user in xmlauth.SelectSingleNode("Users").ChildNodes)
            {
                try
                {
                    User registeredUser = new User();
                    registeredUser.id = int.Parse(user.SelectSingleNode("id").InnerText);
                    lastId = registeredUser.id;
                    registeredUser.username = user.SelectSingleNode("username").InnerText;
                    registeredUser.name = user.SelectSingleNode("name").InnerText;
                    registeredUser.lastname = user.SelectSingleNode("lastname").InnerText;
                    registeredUser.password = user.SelectSingleNode("password").InnerText;
                    registeredUser.course = user.SelectSingleNode("course").InnerText;
                    registeredUser.status = user.SelectSingleNode("status").InnerText;
                    registeredUsers.Add(registeredUser);
                }
                catch
                {
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_confirmPasswordRegister.PasswordChar = '*';
            textBox_passwordLogin.PasswordChar = '*';
            textBox_passwordRegister.PasswordChar = '*';
            label_responseLogin.Hide();
            label_responseRegister.Hide();

            loadRegisteredUsers();
        }

      
            
        private void button_login_Click(object sender, EventArgs e)
            {

            
            bool success = false;
            foreach (User user in registeredUsers)
            {

                if (user.username == textBox_usernameLogin.Text && user.password == textBox_passwordLogin.Text)
                {
                    label_responseLogin.ForeColor = Color.Green;
                    label_responseLogin.Text = "Response: Log In Successful. ID - " + user.id;
                    success = true;
                    if (user.status == "Teacher")
                    {
                        TeacherForm teacherForm = new TeacherForm(registeredUsers, user);
                        this.Hide();
                        teacherForm.ShowDialog();
                        this.Show();
                    }
                    if (user.status == "Student")
                    {
                        StudentForm studentForm = new StudentForm(registeredUsers, user);
                        this.Hide();
                        studentForm.ShowDialog();
                        this.Show();
                    }

                }
            }
            if (!success)
            {
                label_responseLogin.ForeColor = Color.Red;
                label_responseLogin.Text = "Response: Could not log in";
            }
            label_responseLogin.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {


        }

        private void button_register_Click_1(object sender, EventArgs e)
        {

            bool success = true;
            foreach (User user in registeredUsers)
            {
                if (user.username == textBox_usernameRegister.Text)
                {
                    label_responseRegister.ForeColor = Color.Red;
                    label_responseRegister.Text = "Response: Username already taken";
                    success = false;
                    break;
                }
            }
            if (textBox_passwordRegister.Text != textBox_confirmPasswordRegister.Text)
            {
                label_responseRegister.ForeColor = Color.Red;
                label_responseRegister.Text = "Response: Passwords do not match";
                success = false;
            }
            if (textBox_confirmPasswordRegister.Text == string.Empty || textBox_passwordRegister.Text == string.Empty || textBox_usernameRegister.Text == string.Empty || textBox_nameRegister.Text == string.Empty || textBox_lastnameRegister.Text == string.Empty)
            {
                label_responseRegister.ForeColor = Color.Red;
                label_responseRegister.Text = "Response: Some fields are not filled";
                success = false;
            }
            if (success)
            {
                label_responseRegister.Show();

                XmlNode newUser = xmlauth.CreateElement("user");

                XmlNode newUserId = xmlauth.CreateElement("id");
                newUserId.InnerText = (lastId + 1).ToString();
                newUser.AppendChild(newUserId);

                XmlNode newUsername = xmlauth.CreateElement("username");
                newUsername.InnerText = textBox_usernameRegister.Text;
                newUser.AppendChild(newUsername);

                XmlNode newName = xmlauth.CreateElement("name");
                newName.InnerText = textBox_nameRegister.Text;
                newUser.AppendChild(newName);

                XmlNode newLastname = xmlauth.CreateElement("lastname");
                newLastname.InnerText = textBox_lastnameRegister.Text;
                newUser.AppendChild(newLastname);

                XmlNode newPassword = xmlauth.CreateElement("password");
                newPassword.InnerText = textBox_passwordRegister.Text;
                newUser.AppendChild(newPassword);

                XmlNode newStatus = xmlauth.CreateElement("status");
                newStatus.InnerText = comboBox_statusRegister.Text;
                newUser.AppendChild(newStatus);

                XmlNode newCourse = xmlauth.CreateElement("course");
                newCourse.InnerText = comboBox_courseRegister.Text;
                newUser.AppendChild(newCourse);

                if (comboBox_statusRegister.Text == "Student")
                {
                    XmlNode studentid = xmlcourses.CreateElement("studentid");
                    studentid.InnerText = (lastId + 1).ToString();
                    foreach (XmlNode course in xmlcourses.DocumentElement.ChildNodes)
                    {
                        if (course.SelectSingleNode("name").InnerText == comboBox_courseRegister.Text)
                        {
                            course.SelectSingleNode("Students").AppendChild(studentid);


                        }
                    }
                    xmlcourses.Save("../../CourseList.xml");
                }

                xmlauth.DocumentElement.AppendChild(newUser);
                xmlauth.Save("../../UserList.xml");

                label_responseRegister.ForeColor = Color.Green;
                label_responseRegister.Text = "Response: Registration completed";
                textBox_confirmPasswordRegister.Text = string.Empty;
                textBox_passwordRegister.Text = string.Empty;
                textBox_usernameRegister.Text = string.Empty;
                textBox_nameRegister.Text = string.Empty;
                textBox_lastnameRegister.Text = string.Empty;
                comboBox_courseRegister.Text = string.Empty;
                comboBox_statusRegister.Text = string.Empty;
                loadRegisteredUsers();
            }
            label_responseRegister.Show();
        }
    }
}




