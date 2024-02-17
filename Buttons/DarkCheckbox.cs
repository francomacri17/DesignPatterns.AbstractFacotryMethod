namespace DesignPatterns.AbstractFacotryMethod;

public class DarkCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Checkbox");
    }
}