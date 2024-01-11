namespace After_ISP
{
    internal class TwilioSMSNotificationService : ISMSNotificationService
    {
        public void SendSMS(string smsNumber, string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
