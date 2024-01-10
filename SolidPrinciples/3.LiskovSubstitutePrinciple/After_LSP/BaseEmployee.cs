using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_LSP
{
    /// <summary>
    /// Common for all.
    /// We can make it abstract to be sure that this is not used directly but only inherited.
    /// </summary>
    public class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }


        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount * (rank * 2);
        }
    }
}
