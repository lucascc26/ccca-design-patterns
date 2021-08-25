using DesignPatterns.Creational.AbstractFactory;
using Xunit;

namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    public class ViewTests
    {
        [Fact]
        public void Should_create_a_view_with_dark_theme()
        {
            var view = new View(new DarkThemeFactory());
            Assert.Equal("black", view.Button.BackgroundColor);
            Assert.Equal("white", view.Button.Color);
            Assert.Equal("white", view.Label.Color);
        }

        [Fact]
        public void Should_create_a_view_with_light_theme()
        {
            var view = new View(new LightThemeFactory());
            Assert.Equal("white", view.Button.BackgroundColor);
            Assert.Equal("black", view.Button.Color);
            Assert.Equal("black", view.Label.Color);
        }
    }
}
