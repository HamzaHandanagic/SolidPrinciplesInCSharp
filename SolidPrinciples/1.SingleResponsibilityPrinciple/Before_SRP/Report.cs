namespace Before_SRP
{
    /// <summary>
    /// Report class is responsible for both generating a report and sending it via email.
    /// </summary>
    public class Report
    {
        public string Name { get; set; }
        public string Content { get; set; }

        public void GenerateReport()
        {
            Name = "Invoice Report";
            Content = "Report Content";
        }

        public void SendReportByEmail(string recipient)
        {
            Console.WriteLine($"Sending report to {recipient} via email: {Content}");
        }
    }
}
