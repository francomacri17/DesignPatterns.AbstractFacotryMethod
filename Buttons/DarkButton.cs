namespace DesignPatterns.AbstractFacotryMethod;

public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Button");
    }
}