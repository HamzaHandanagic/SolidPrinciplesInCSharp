using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_LSP
{
    /// <summary>
    /// Inherits from Employee. Overrides method and has one additional method.
    /// </summary>
    public class Manager : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.50M;

            Salary = baseAmount * (rank * 4);
        }

        public void GeneratePerformanceReview() 
        {
            Console.WriteLine("Performance review direct report.");
        }
    }
}
