namespace DesignPatterns.Creational.AbstractFactory
{
    public class View
    {
        public ILabel Label { get; private set; }
        public IButton Button { get; private set; }

        public View(IAbstractThemeFactory themeFactory)
        {
            Label = themeFactory.CreateLabel();
            Button = themeFactory.CreateButton();
        }
    }
}
