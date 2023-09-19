using H1_The_firm.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm.Model
{
    /// <summary>
    /// The manager inherits from employee, however a manager has a phone number, 
    /// which gets created as a variable in this class.
    /// This means that manager has all the same variables as employee, but also a new variable for the phone number.
    /// </summary>
    internal class Manager : Employee
    {
        private protected string _phoneNumber = "";

        internal Manager(string firstName, string lastName, string ssn, string phoneNumber) : base(firstName, lastName, ssn)
        {
            _phoneNumber = phoneNumber;
        }

        /// <summary>
        /// This method returns the same variable values as the employee "ToString()", 
        /// however it now also has the phone number, which gets returned as well, to the controller.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} Phone: {_phoneNumber}";
        }
    }
}
