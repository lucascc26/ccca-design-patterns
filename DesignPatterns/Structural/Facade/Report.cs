namespace DesignPatterns.Structural.Facade
{
    public class Report
    {
        private ReportHeader _header;
        private ReportBody _body;
        private ReportFooter _footer;

        public void SetHeader(ReportHeader header)
        {
            _header = header;
        }

        public void SetBody(ReportBody body)
        {
            _body = body;
        }

        public void SetFooter(ReportFooter footer)
        {
            _footer = footer;
        }

        public string Generate()
        {
            return $"<div>{_header?.Value}</div><div>{_body?.Value}</div><div>{_footer?.Value}</div>";
        }
    }
}
