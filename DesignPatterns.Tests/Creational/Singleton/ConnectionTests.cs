using DesignPatterns.Creational.Singleton;
using Xunit;

namespace DesignPatterns.Tests.Creational.Singleton
{
    public class ConnectionTests
    {
        [Fact]
        public void Should_connect_to_the_same_instance()
        {
            var connection1 = Connection.Instance;
            var connection2 = Connection.Instance;
            Assert.Equal(connection1.Id, connection2.Id);
        }
    }
}
