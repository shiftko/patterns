using System.Reflection;
using Strategy.SimUDuck.Behavior.Flying;
using Strategy.SimUDuck.Behavior.SoundProducing;

namespace Strategy.SimUDuck;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        _flyManager = new FlyWithWings();
        _quackManager = new Squeak();
    }

    public override void PerformFly()
    {
        _flyManager.Fly();
    }

    public override void MakeSound()
    {
        _quackManager.MakeSound();
    }

    public override void Display()
    {
        Console.WriteLine($"Display: {nameof(RedheadDuck)}.{MethodBase.GetCurrentMethod()?.Name}");
    }
}