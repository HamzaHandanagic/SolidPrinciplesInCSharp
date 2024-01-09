using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_SRP
{
    /// <summary>
    /// Report class only have responsibility of creating reports.
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
    }
}
