using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LinqToSqlProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new LinqToSqlProject.CompanyDBDataContext();
            ISingleResult<Employee_SelectResult> tab =  dc.Employee_Select("Sales");  //tab is a table returns ISingleResult.  In paramemter, specify department name
            dataGridView1.DataSource = tab;  //
            
        }
    }
}
