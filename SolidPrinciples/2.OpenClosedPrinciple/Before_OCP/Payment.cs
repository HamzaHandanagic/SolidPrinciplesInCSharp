using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Before_OCP
{
    /// <summary>
    /// This does not follow the OCP because when we need to add new Payment types we need to change the code and add new cases.
    /// </summary>
    public class Payment
    {
        public void Pay(PaymentType attackType)
        {
            switch (attackType)
            {
                case PaymentType.Bank:
                    Console.WriteLine("Perform payment with Bank type.");
                    break;
                case PaymentType.PayPal:
                    Console.WriteLine("Perform payment with PayPal type.");
                    break;
                case PaymentType.Mastercard:
                    Console.WriteLine("Perform payment with Mastercard type.");
                    break;
                default:
                    Console.WriteLine("Payment type not found.");
                    break;
            }
        }
    }

    public enum PaymentType
    {
        Bank,
        PayPal,
        Mastercard
    }
}
