namespace Before_ISP
{
    /// <summary>
    /// This service is not interested in sending SMS and this is issue.
    /// </summary>
    internal class SendGridNotificationService : INotificationService
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email : {message}");
        }

        public void SendSMS(string smsNumber, string message)
        {
            throw new NotImplementedException();
        }
    }
}
