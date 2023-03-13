namespace Strategy.SimUDuck.Behavior.Flying;

public class FlyWithWings : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }
}