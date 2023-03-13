// See https://aka.ms/new-console-template for more information

using Strategy.SimUDuck;

var mallardDuck = new MallardDuck();
mallardDuck.MakeSound();
mallardDuck.PerformFly();
mallardDuck.Swim();

Console.WriteLine();

var rubberDuck = new RubberDuck();
rubberDuck.MakeSound();
rubberDuck.PerformFly();
rubberDuck.Swim();

Console.WriteLine();

var redheadDuck = new RedheadDuck();
redheadDuck.MakeSound();
redheadDuck.PerformFly();
redheadDuck.Swim();