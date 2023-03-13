namespace Strategy.SimUDuck.Behavior.SoundProducing;

public class Mute : ISoundMaker
{
    public void MakeSound()
    {
        Console.WriteLine("I can't make sound");
    }
}