using DesignPatterns.AbstractFacotryMethod;

class Program
{
    static void Main(string[] args)
    {
        // Create a Light Theme UI
        IGUIFactory lightFactory = new LightThemeFactory();
        var lightButton = lightFactory.CreateButton();
        var lightCheckbox = lightFactory.CreateCheckbox();
        lightButton.Render();
        lightCheckbox.Render();

        // Create a Dark Theme UI
        IGUIFactory darkFactory = new DarkThemeFactory();
        var darkButton = darkFactory.CreateButton();
        var darkCheckbox = darkFactory.CreateCheckbox();
        darkButton.Render();
        darkCheckbox.Render();
    }
}
