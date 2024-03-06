using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationAPplication
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            string[] months = { "January", "February", "March", "April", "June", "July", "August", "September", "Otocber", "November", "December" };
            foreach (string i in months)
            {
                comboBox2.Items.Add(i.ToString());
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }

            string[] listOfProgram = { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Engineering" };
            foreach (string i in listOfProgram)
            {
                comboBox4.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string Lastname = textBox1.Text;
                string Firstname = textBox2.Text;
                string Middlename = textBox3.Text;

                string day = comboBox1.GetItemText(comboBox1.SelectedItem);
                string month = comboBox2.GetItemText(comboBox2.SelectedItem);
                string year = comboBox3.GetItemText(comboBox3.SelectedItem);

                string Program = comboBox4.GetItemText(comboBox4.SelectedItem);

                string Gender = radioButton1.Checked == true ? "Male" : "Female";

                MessageBox.Show("Student: " + Firstname + " " + Middlename + " " + Lastname + "\nGender: " + Gender + "\nDate Of Birth: " + day + "/" + month + "/" + year + "\nProgram: " + Program);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
