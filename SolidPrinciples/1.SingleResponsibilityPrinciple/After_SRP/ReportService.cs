namespace After_SRP
{
    public class ReportService
    {
        public void GenerateAndSendReport(string recipient)
        {
            Report report = new Report();
            string reportContent = report.GenerateReport();

            EmailSender sender = new EmailSender();
            sender.SendReportByEmail(reportContent, recipient);
        }
    }
}
