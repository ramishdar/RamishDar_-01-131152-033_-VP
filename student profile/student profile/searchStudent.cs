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
    public partial class searchStudent : Form
    {
        public searchStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enroll = textBox1.Text;
            Student_functions obj = new Student_functions();
            string[] student=obj.searchEnroll(enroll);
            if(student!=null)
            {
                ListViewItem item = new ListViewItem(student[0]);
                item.SubItems.Add(student[1]);
                this.listView1.Items.Add(item);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            Hide();
            obj.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
