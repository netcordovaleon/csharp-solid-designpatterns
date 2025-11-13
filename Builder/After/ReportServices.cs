namespace Builder.After
{
    public class ReportServices
    {
        public void GenerateReport() { 
            var report = new ReportBuilder()
                .SetTitle("Sales Report Q4")
                .SetHeader("Company Confidential")
                .SetBody("Data and graphs for Q4...")
                .SetFooter("Generated automatically")
                .SetAuthor("Luis Córdova")
                .SetFormat("PDF")
                .Build();
        }
    }
}
