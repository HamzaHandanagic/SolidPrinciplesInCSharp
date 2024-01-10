using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_LSP
{
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
