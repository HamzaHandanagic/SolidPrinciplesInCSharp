using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_OCP
{
    /// <summary>
    /// In this example we follow OCP. We are able to add new attack types without ever changing the code here. We are adding new classes.
    /// This can be done also with abstract class: BasePaymentClass with abstract method Pay and then override that in derived classes.
    /// </summary>
    public class Payment
    {
        public void Pay(IPayment payment)
        {
            payment.ProcessPayment();
        }
    }
}
