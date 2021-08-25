namespace DesignPatterns.Creational.AbstractFactory
{
    public class DarkButton : IButton
    {
        public string Color => "white";

        public string BackgroundColor => "black";
    }
}
