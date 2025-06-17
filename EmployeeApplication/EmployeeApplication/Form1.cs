using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnComputeSalary_Click_1(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            string jobTitle = txtJobTitle.Text;
            double ratePerHour = double.Parse(txtRatePerHour.Text);
            int hoursWorked = int.Parse(txtHoursWorked.Text);


            PartTimeEmployee employee = new PartTimeEmployee(firstName, lastName, department, jobTitle);


            employee.computeSalary(hoursWorked, ratePerHour);


            lblFirstName.Text = employee.FirstName;
            lblLastName.Text = employee.LastName;
            lblBasicSalary.Text = employee.getSalary().ToString("0.00");

        }
    }
}
