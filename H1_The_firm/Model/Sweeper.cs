using H1_The_firm.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_The_firm.Model
{
    /// <summary>
    /// This class has the same attributes as the Employee class, which this class inherits from.
    /// </summary>
    internal class Sweeper : Employee
    {
        internal Sweeper(string firstName, string lastName, string socialSecurityNumber) : base(firstName, lastName, socialSecurityNumber)
        {
        }
    }
}
