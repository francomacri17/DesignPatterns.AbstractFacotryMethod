namespace DesignPatterns.AbstractFacotryMethod;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}