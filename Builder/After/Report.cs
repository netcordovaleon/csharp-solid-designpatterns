namespace Builder.After
{
    public  class Report
    {
        public string? Title { get; set; }
        public string? Header { get; set; }
        public string? Body { get; set; }
        public string? Footer { get; set; }
        public string? Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Format { get; set; }

        public override string ToString()
        {
            return $"Report: {Title}\nBy: {Author}\nDate: {CreatedDate}\nFormat: {Format}\nHeader: {Header}\nBody: {Body}\nFooter: {Footer}";
        }
    }
}
