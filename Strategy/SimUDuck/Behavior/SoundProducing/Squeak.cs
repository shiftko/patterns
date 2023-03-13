namespace Strategy.SimUDuck.Behavior.SoundProducing;

public class Squeak : ISoundMaker
{
    public void MakeSound()
    {
        Console.WriteLine("Squeak - squeak");
    }
}