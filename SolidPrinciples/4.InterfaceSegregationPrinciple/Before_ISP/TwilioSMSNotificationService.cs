namespace Before_ISP
{
    /// <summary>
    /// This service is not interested in sending Email and this is issue.
    /// </summary>
    internal class TwilioSMSNotificationService : INotificationService
    {
        public void SendEmail(string to, string message)
        {
            throw new NotImplementedException();
        }

        public void SendSMS(string smsNumber, string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
