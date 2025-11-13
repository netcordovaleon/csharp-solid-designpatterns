namespace Builder.After
{
    public class ReportBuilder
    {

       private readonly Report _report = new Report();

        public ReportBuilder SetTitle(string title)
        {
            _report.Title = title;
            return this;
        }

        public ReportBuilder SetHeader(string header)
        {
            _report.Header = header;
            return this;
        }

        public ReportBuilder SetBody(string body)
        {
            _report.Body = body;
            return this;
        }

        public ReportBuilder SetFooter(string footer)
        {
            _report.Footer = footer;
            return this;
        }

        public ReportBuilder SetAuthor(string author)
        {
            _report.Author = author;
            return this;
        }

        public ReportBuilder SetFormat(string format)
        {
            _report.Format = format;
            return this;
        }

        public ReportBuilder SetCreatedDate(DateTime date)
        {
            _report.CreatedDate = date;
            return this;
        }

        public Report Build()
        {
            // Validaciones o valores por defecto
            if (string.IsNullOrEmpty(_report.Format))
                _report.Format = "PDF";

            _report.CreatedDate = _report.CreatedDate == default ? DateTime.Now : _report.CreatedDate;

            return _report;
        }

    }
}
