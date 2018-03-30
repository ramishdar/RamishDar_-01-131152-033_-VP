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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newStudent obj = new newStudent();
            Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteStudent obj = new deleteStudent();
            Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchStudent obj = new searchStudent();
            Hide();
            obj.Show();
        }
    }
}
