using System;
using System.IO;

namespace Ramish_Assignment
{
    public class functions
    {
        public void enterstudent(string name, string enroll, string degree, int semester, float cgpa, string uni, string path)
        {

          
                using (StreamWriter sw = File.AppendText(path))//to append the data at the end of text file
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
        public void deletestudent(string path, string id)
        {
          
            StreamReader file = new StreamReader(path);
            string line;    //reading integers
            int addition = 0;
            while ((line = file.ReadLine()) != null)
            {
                addition++;
            }
            file.Close();
            file = new StreamReader(path);
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
            using (StreamWriter newfile = new StreamWriter(path))
            {
                for (int i = 0; i < length.Length; i++)
                {
                    newfile.WriteLine(length[i]);
                }

            }
            Console.WriteLine("\n\t\tRecord has been deleted");
        }
        public void searchEnroll(string enroll, string path)
        {
            string line;

            bool check= false;
            StreamReader st = new StreamReader(path);
            while ((line = st.ReadLine())  != null)
            {
                Console.WriteLine(line);
                for (int i = 0; i < 5; i++)
                {
                    if (line == enroll)
                    {
                        check = true;
                    }
                    Console.Write(line);


                }
                Console.WriteLine("");
               

            }
            if (check == true)
            {
                Console.WriteLine("\n\nFound");
            }
          

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "1- New Student");
            Console.WriteLine("\t" + "2- Delete Student ");
            Console.WriteLine("\t" + "3- Search Student by Enrollment");
            Console.WriteLine("\t" + "4- Search Student by Name");
            
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    
                    string name, enroll, degree, uni;
                    int semester;
                    float cgpa;
                    Console.WriteLine("Enter Name : ");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter Enrollment : ");
                    enroll = Console.ReadLine();
                    Console.WriteLine("Enter degree : ");
                    degree = Console.ReadLine();
                    Console.WriteLine("Enter cgpa : ");
                    cgpa = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter semester : ");
                    semester = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter University : ");
                    uni = Console.ReadLine();

                    functions obj = new functions();
                    obj.enterstudent(name, enroll, degree, semester, cgpa, uni, "c:/file.txt");
                    break;
                case "2":
                    Console.WriteLine("Enter Enrollment : ");
                    String myenroll = Console.ReadLine();

                    functions obj2 = new functions();
                    obj2.deletestudent("c:/file.txt", myenroll);

                    break;
                case "3":
                    Console.WriteLine("Enter Enrollment : ");
                    String myenroll2 = Console.ReadLine();

                    functions obj3 = new functions();
                    obj3.searchEnroll(myenroll2, "c:/file.txt");
                    break;

                case "4":
                    Console.WriteLine("Enter Name : ");
                    String name2 = Console.ReadLine();

                    functions obj4 = new functions();
                    obj4.searchEnroll(name2, "c:/file.txt");
                    break;

                default:
                    break;
            }
        }
    }
}
