namespace Before_ISP
{
    public interface INotificationService
    {
        void SendSMS(string smsNumber, string message);
        void SendEmail(string to, string message);
    }
}
