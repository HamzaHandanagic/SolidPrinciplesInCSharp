using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_OCP
{
    internal class MasterCardPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Perform payment with MasterCard type.");
        }
    }
}
