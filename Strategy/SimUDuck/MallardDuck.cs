using System.Reflection;
using Strategy.SimUDuck.Behavior.Flying;
using Strategy.SimUDuck.Behavior.SoundProducing;

namespace Strategy.SimUDuck;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        _flyManager = new FlyWithWings();
        _quackManager = new Quack();
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
        Console.WriteLine($"Display: {nameof(MallardDuck)}.{MethodBase.GetCurrentMethod()?.Name}");
    }
}