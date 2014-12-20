using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeStudentInfoApp
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        string Message;
        string info = ("Regitration No                   FullName" + "\n");
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           
            Student student1 = new Student();
            if (count < 3)
            {
                student1.regNo = regNoTextBox.Text;
                student1.firstName = firstNameTextBox.Text;
                student1.lastName = lastNameTextBox.Text;

                regNoTextBox.Text = string.Empty;
                firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;



                students.Add(student1);
                count++;
            }
            else
            {
                MessageBox.Show("Can't add");

            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (Student astudent in students)
            {
                Message += (astudent.regNo + "                                          " + astudent.GetFullName() + "\n");

            }
            MessageBox.Show(info + Message);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Message = string.Empty;
            students.Clear();
        }
    }
}
