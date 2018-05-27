using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FORM 4: Employee Details Form performs CRUD operations

namespace LinqToSqlProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   //save button for Form4.  Note: we differentiate between insert and update operation 
        {
            
                CompanyDBDataContext dc = new CompanyDBDataContext();  //establish connection
            if (textBox1.ReadOnly == false) // insert operation is happening
            {
                Employee obj = new Employee();
                obj.Eno = int.Parse(textBox1.Text);
                obj.Ename = textBox2.Text;
                obj.Job = textBox3.Text;
                obj.Salary = decimal.Parse(textBox4.Text);
                obj.Dname = textBox5.Text;

                dc.Employees.InsertOnSubmit(obj); //pending insert 
                dc.SubmitChanges();     //commit the data
                MessageBox.Show("Record inserted into the table.");
            }
            else  //update operation triggered on Form3 and now new entries must be inserted in this Form4
            {
                Employee obj = dc.Employees.SingleOrDefault(E => E.Eno == int.Parse(textBox1.Text)); //reference to existing record.  Use lambda to access values
                obj.Ename = textBox2.Text; //user modified value is in textbox
                obj.Job = textBox3.Text;
                obj.Salary = decimal.Parse(textBox4.Text);
                obj.Dname = textBox5.Text;
                dc.SubmitChanges();
                MessageBox.Show("Record updated in the table.");
            }
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
