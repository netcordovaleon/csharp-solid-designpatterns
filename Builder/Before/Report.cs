namespace Builder.Before
{
    public class Report
    {
        public string Title { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Format { get; set; }

        public Report(string title, string header, string body, string footer, string author, DateTime createdDate, string format)
        {
            Title = title;
            Header = header;
            Body = body;
            Footer = footer;
            Author = author;
            CreatedDate = createdDate;
            Format = format;
        }
    }
}
