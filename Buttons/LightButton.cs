namespace DesignPatterns.AbstractFacotryMethod;

public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Button");
    }
}