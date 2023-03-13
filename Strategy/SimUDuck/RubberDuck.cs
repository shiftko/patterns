using System.Reflection;
using Strategy.SimUDuck.Behavior.Flying;
using Strategy.SimUDuck.Behavior.SoundProducing;

namespace Strategy.SimUDuck;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        _quackManager = new Mute();
        _flyManager = new CannotFly();
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
        Console.WriteLine($"Display: {nameof(RubberDuck)}.{MethodBase.GetCurrentMethod()?.Name}");
    }
}