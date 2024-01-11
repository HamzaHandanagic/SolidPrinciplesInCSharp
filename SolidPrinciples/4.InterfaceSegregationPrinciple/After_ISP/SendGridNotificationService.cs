namespace After_ISP
{
    internal class SendGridNotificationService : IEmailNotificationService
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email : {message}");
        }
    }
}
