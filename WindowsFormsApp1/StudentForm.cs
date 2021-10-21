using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentForm : Form
    {
        List<User> Users = new List<User>();
        User Self = new User();
        public StudentForm(List<User> registeredusers, User self)
        {
            this.Users = registeredusers;
            this.Self = self;

            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
