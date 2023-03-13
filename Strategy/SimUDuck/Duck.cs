using Strategy.SimUDuck.Behavior;

namespace Strategy.SimUDuck;

public abstract class Duck
{
    protected IFlyable _flyManager;
    protected ISoundMaker _quackManager;

    public void Swim()
    {
        Console.WriteLine("I'm swimming");
    }

    public abstract void PerformFly();

    public abstract void MakeSound();

    public abstract void Display();
}