using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before_LSP
{
    /// <summary>
    /// Inhertis from Employee. Has additional methods.
    /// </summary>
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 50M;

            Salary = baseAmount * rank;
        }
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Performance review direct report.");
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no manager.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You are fired.");
        }

        public void HireSomeone()
        {
            Console.WriteLine("You are hired.");
        }
    }
}
