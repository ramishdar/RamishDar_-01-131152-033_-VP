using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_profile
{
    public partial class newStudent : Form
    {
        public newStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            Hide();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string name, enroll,  degree, semester, cgpa,uni;
            name = text_name.Text;
            enroll = text_id.Text;
            degree = text_degree.Text;
            semester = text_semester.Text;
            cgpa = text_cgpa.Text;
            uni = text_university.Text;
            Student_functions obj = new Student_functions();
            obj.enterstudent(name, enroll, degree, semester, cgpa, uni);
            MessageBox.Show("Student Added");
        }
    }
}
