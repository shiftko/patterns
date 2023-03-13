namespace Strategy.SimUDuck.Behavior.Flying;

public class CannotFly : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}