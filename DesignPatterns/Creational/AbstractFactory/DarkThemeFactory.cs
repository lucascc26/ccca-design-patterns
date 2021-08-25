namespace DesignPatterns.Creational.AbstractFactory
{
    public class DarkThemeFactory : IAbstractThemeFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ILabel CreateLabel()
        {
            return new DarkLabel();
        }
    }
}
