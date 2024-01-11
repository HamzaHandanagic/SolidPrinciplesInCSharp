namespace After_ISP
{
    public interface ISMSNotificationService
    {
        void SendSMS(string smsNumber, string message);
    }
}
