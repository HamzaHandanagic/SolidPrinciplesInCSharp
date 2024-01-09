namespace Before_SRP
{
    /// <summary>
    /// Report class is responsible for both generating a report and sending it via email.
    /// </summary>
    public class Report
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public string GenerateReport()
        {
            var generatedReport = $"{Name}:{Content}";
            return generatedReport;
        }

        public void SendReportByEmail(string recipient)
        {
            Console.WriteLine($"Sending report to {recipient} via email: {Content}");
        }
    }
}
