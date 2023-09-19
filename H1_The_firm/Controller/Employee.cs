using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm.Controller
{
    /// <summary>
    /// This is the most basic employee type.
    /// The employee has a first and last name, as well as a social security number.
    /// Every other employee type inherit from this class.
    /// </summary>
    internal class Employee
    {
        private protected string _firstName;
        private protected string _lastName;
        private protected string _socialSecurityNumber;

        internal Employee(string first, string lastName, string socialSecurityNumber)
        {
            _firstName = first;
            _lastName = lastName;
            _socialSecurityNumber = socialSecurityNumber;
        }

        /// <summary>
        /// This method allows the controller to call the view, with the values from the variables for an employee.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}. SSN: {_socialSecurityNumber}";
        }
    }
}
