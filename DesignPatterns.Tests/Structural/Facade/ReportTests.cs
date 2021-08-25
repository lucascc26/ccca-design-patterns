using DesignPatterns.Structural.Facade;
using Xunit;

namespace DesignPatterns.Tests.Structural.Facade
{
    public class ReportTests
    {
        [Fact]
        public void Should_generate_a_report()
        {
            var reportFacade = new ReportFacade("Header", "Body", "Footer");
            var reportHtml = reportFacade.Generate();
            Assert.Equal("<div>Header</div><div>Body</div><div>Footer</div>", reportHtml);
        }
    }
}
