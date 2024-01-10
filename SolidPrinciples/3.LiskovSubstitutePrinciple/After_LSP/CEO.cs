using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_LSP
{
    internal class CEO : BaseEmployee, IManager
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
