using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInterface;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {

        private string first_name;
        private string last_name;
        private string department;
        private string job_title;
        private double basic_salary;

        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string JobTitle
        {
            get { return job_title; }
            set { job_title = value; }
        }

        public double BasicSalary
        {
            get { return basic_salary; }
        }

        public PartTimeEmployee(string firstName, string lastName, string dept, string job)
        {
            first_name = firstName;
            last_name = lastName;
            department = dept;
            job_title = job;
            basic_salary = 0.0;
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return basic_salary;
        }
    }
}
