using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1_The_firm.Model;

namespace H1_The_firm.Controller
{
    /// <summary>
    /// Contains a bunch of methods for creating employee types.
    /// Each "Create" method creates an instance of an employee type, which gets a bunch of variables to define them.
    /// Once the employee type has been created and assigned values, 
    /// then the method calls the view class and outputs the employee type, 
    /// as well as the variable values that the employee has.
    /// </summary>
    internal class Controller
    {
        View.View view = new();

        /// <summary>
        /// This is the entry point, when called from the main method.
        /// The Start() method takes care of calling different employee types, which creates them
        /// </summary>
        internal void Start()
        {
            CreateEmployee();
            CreateSweeper();
            CreateManager();
            CreateProjectManager();
        }

        private void CreateEmployee()
        {
            string firstName = "Magnus";
            string lastName = "Lund";
            string socialSecurity = "1234560000";
            Employee employee = new(firstName, lastName, socialSecurity);
            view.Message($"Employee:\n{employee}\n");
        }

        private void CreateSweeper()
        {
            string firstName = "Magnus";
            string lastName = "Lund";
            string socialSecurity = "1234560000";
            Sweeper sweeper = new(firstName, lastName, socialSecurity);
            view.Message($"Sweeper:\n{sweeper}\n");
        }

        private void CreateManager()
        {
            string firstName = "Magnus";
            string lastName = "Lund";
            string socialSecurity = "1234560000";
            string phoneNumber = "12341234";
            Manager manager = new(firstName, lastName, socialSecurity, phoneNumber);
            view.Message($"Manager:\n{manager}\n");
        }

        private void CreateProjectManager()
        {
            string firstName = "Magnus";
            string lastName = "Lund";
            string socialSecurity = "1234560000";
            string phoneNumber = "12341234";
            string email = "mail";
            ProjectManager projectManager = new(firstName, lastName, socialSecurity, phoneNumber, email);
            view.Message($"Project Manager:\n{projectManager}\n");
        }
    }
}
