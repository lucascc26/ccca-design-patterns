namespace DesignPatterns.Structural.Facade
{
    public class ReportFacade
    {
        private readonly Report _report;

        public ReportFacade(string header, string body, string footer)
        {
            _report = new Report();
            _report.SetHeader(new ReportHeader(header));
            _report.SetBody(new ReportBody(body));
            _report.SetFooter(new ReportFooter(footer));
        }

        public string Generate()
        {
            return _report.Generate();
        }
    }
}
