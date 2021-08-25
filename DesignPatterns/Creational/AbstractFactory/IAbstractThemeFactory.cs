namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IAbstractThemeFactory
    {
        ILabel CreateLabel();
        IButton CreateButton();
    }
}
