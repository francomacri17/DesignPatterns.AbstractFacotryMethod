namespace DesignPatterns.AbstractFacotryMethod;

public class LightThemeFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new LightButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new LightCheckbox();
    }
}