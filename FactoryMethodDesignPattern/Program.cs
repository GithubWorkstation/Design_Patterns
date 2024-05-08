using System;

// Product interface
interface IHuman
{
    void Speak();
}

// Concrete Products
class Man : IHuman
{
    public void Speak()
    {
        Console.WriteLine("I am a man.");
    }
}

class Woman : IHuman
{
    public void Speak()
    {
        Console.WriteLine("I am a woman.");
    }
}

// Creator interface
interface IHumanCreator
{
    IHuman CreateHuman();
}

// Concrete Creators
class ManCreator : IHumanCreator
{
    public IHuman CreateHuman()
    {
        return new Man();
    }
}

class WomanCreator : IHumanCreator
{
    public IHuman CreateHuman()
    {
        return new Woman();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Factory Method Pattern Example");

        IHumanCreator creator = new ManCreator();
        IHuman human = creator.CreateHuman();
        human.Speak();

        creator = new WomanCreator();
        human = creator.CreateHuman();
        human.Speak();
    }
}
