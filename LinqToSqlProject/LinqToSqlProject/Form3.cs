using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//FORM 3 contains insert, update, delete, close buttons for CRUD operations

namespace LinqToSqlProject
{
    public partial class Form3 : Form
    {
        CompanyDBDataContext dc;
        public Form3()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dc = new CompanyDBDataContext();
            dgView.DataSource = dc.Employees;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)  //UPDATE BUTTON
        {
            if (dgView.SelectedRows.Count > 0)       //select a record to update
            {
                Form4 f = new Form4();
                f.textBox1.ReadOnly = true;     //we don't want empoyee number to be modified
               // f.button2_Click.Enabled = false;       //disable clear button for popup Form4
              //  f.button1_Click.Text = "Update";    //change caption of popup Form4
                f.textBox1.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();  //access the fields in textbox after setting their modifier to Internal
                f.textBox2.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                f.textBox3.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                f.textBox4.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
                f.textBox5.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
                LoadData();

            }
            else
                MessageBox.Show("Please select a record to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e) //Delete button
        {
            if(dgView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Are you sure of deleting the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)   ////user clicked yes 
                {
                    int Eno = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value);
                    Employee obj = dc.Employees.SingleOrDefault(E => E.Eno == Eno); //becomes reference of existing record
                    dc.Employees.DeleteOnSubmit(obj);
                    dc.SubmitChanges();
                    LoadData();

                }
            }
            else
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e) //Close button
        {
            this.Close();
        }
    }
}
