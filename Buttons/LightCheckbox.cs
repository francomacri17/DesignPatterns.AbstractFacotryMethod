namespace DesignPatterns.AbstractFacotryMethod;

public class LightCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Checkbox");
    }
}