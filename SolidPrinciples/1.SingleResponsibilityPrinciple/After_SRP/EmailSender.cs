using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_SRP
{
    /// <summary>
    /// EmailSender class only have responsibility of sending emails.
    /// </summary>
    public class EmailSender
    {
        public void SendReportByEmail(string content, string recipient)
        {
            Console.WriteLine($"Sending report to {recipient} via email: {content}");
        }
    }
}
