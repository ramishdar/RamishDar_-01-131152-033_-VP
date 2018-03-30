using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace student_profile
{
    class Student_functions
    {
        public void enterstudent(string name, string enroll, string degree, string semester, string cgpa, string uni)
        {
            using (StreamWriter sw = File.AppendText("E://Student Record.txt"))//to append the data at the end of text file
            {

                sw.WriteLine(enroll);
                sw.WriteLine(name);
                sw.WriteLine(degree);
                sw.WriteLine(semester);
                sw.WriteLine(cgpa);
                sw.WriteLine(uni);

                sw.Dispose();
            }

        }
        public void deletestudent(string id)
        {

            StreamReader file = new StreamReader("E://Student Record.txt");
            string line;    //reading integers
            int addition = 0;
            while ((line = file.ReadLine()) != null)
            {
                addition++;
            }
            file.Close();
            file = new StreamReader("E://Student Record.txt");
            string[] length = new string[addition]; //passing string to n lines
            for (int i = 0; i < addition; i++)
            {
                length[i] = file.ReadLine();
                if (length[i] == id.ToString()) //if condition is true
                {
                    length[i] = null;   //make it null
                    i--;                //decrement previous records
                    for (int j = 0; j < 5; j++)
                    {
                        line = file.ReadLine();
                    }
                }
            }
            file.Close();
            using (StreamWriter newfile = new StreamWriter("E://Student Record.txt"))
            {
                for (int i = 0; i < length.Length; i++)
                {
                    newfile.WriteLine(length[i]);
                }

            }
            
        }
        public string[] searchEnroll(string enroll)
        {
            string line;
            string[] student = new string[2];
            bool check= false;
            int i = 0;
            StreamReader st = new StreamReader("E://Student Record.txt");
            while ((line = st.ReadLine())  != null)
            {
                if(line==enroll)
                {
                    student[i++] = line;
                    line = st.ReadLine();
                    student[i++] = line;
                    break;
                }
            }
            st.Close();
            return student;
          

        }

    }
    

}
