using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Access and retrieve data from database row by row using linq

namespace LinqToSqlProject
{
    public partial class Form2 : Form
    {
        CompanyDBDataContext dc;
        List<Employee> Emps;
        int rno = 0; //index position

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dc = new CompanyDBDataContext();    //create DataContext to connect to database
            Emps = dc.Employees.ToList();       //Create list of Employees. ToList() converts returned table to list
            ShowData();

        }

        private void ShowData()
        {
            textBox1.Text = Emps[rno].Eno.ToString();   //assign values to textboxes in Form2.cs
            textBox2.Text = Emps[rno].Ename;
            textBox3.Text = Emps[rno].Job;
            textBox4.Text = Emps[rno].Salary.ToString();
            textBox5.Text = Emps[rno].Dname;

        }

        private void button1_Click(object sender, EventArgs e)     //go to previous entry in table
        {
            if (rno > 1)
            {
                rno = rno - 1;
                ShowData();
            }
            else
                MessageBox.Show("First record of the table.");

        }

        private void button2_Click(object sender, EventArgs e)     //go to next entry
        {
            if (rno < Emps.Count - 1)
            {
                rno = rno + 1;
                ShowData();
            }
            else
                MessageBox.Show("Last record of the table.");
           
        }

        private void button3_Click(object sender, EventArgs e)    //close the application
        {
            this.Close();
        }
    }
}
