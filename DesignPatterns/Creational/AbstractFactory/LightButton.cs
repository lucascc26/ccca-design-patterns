namespace DesignPatterns.Creational.AbstractFactory
{
    public class LightButton : IButton
    {
        public string Color => "black";

        public string BackgroundColor => "white";
    }
}
