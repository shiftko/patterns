namespace Strategy.SimUDuck.Behavior.SoundProducing;

public class Quack : ISoundMaker
{
    public void MakeSound()
    {
        Console.WriteLine("Quack - Quack");
    }
}