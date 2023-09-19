using H1_The_firm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm.Controller
{
    /// <summary>
    /// The project manager inherits from the manager.
    /// This means that the project manager has the same variables as the manager, which has the same as the employee.
    /// However project managers have emails, which requires a new variables.
    /// </summary>
    internal class ProjectManager : Manager
    {
        private protected string _email;

        internal ProjectManager(string firstName, string lastName, string ssn, string number,string email) : base (firstName, lastName, ssn, number)
        {
            _email = email;
        }

        /// <summary>
        /// The "ToString()" method now works the same as the managers "ToString()".
        /// It return all the previous variables, such as firstname and phone number, however now email is added.
        /// This information is given to the controller which gives it to the view, for a console output.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()} email: {_email}";
        }
    }
}
