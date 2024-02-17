namespace DesignPatterns.AbstractFacotryMethod;

public class DarkThemeFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new DarkButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new DarkCheckbox();
    }
}