namespace DesignPatterns.Creational.AbstractFactory
{
    public class LightThemeFactory : IAbstractThemeFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ILabel CreateLabel()
        {
            return new LightLabel();
        }
    }
}
