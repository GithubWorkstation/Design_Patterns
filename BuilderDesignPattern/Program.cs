using System;

// Product
class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name}, I'm {Age} years old, and I'm {Gender}.");
    }
}

// Builder interface
interface IHumanBuilder
{
    void SetName(string name);
    void SetAge(int age);
    void SetGender(string gender);
    Human GetHuman();
}

// Concrete Builder
class HumanBuilder : IHumanBuilder
{
    private Human human = new Human();

    public void SetName(string name)
    {
        human.Name = name;
    }

    public void SetAge(int age)
    {
        human.Age = age;
    }

    public void SetGender(string gender)
    {
        human.Gender = gender;
    }

    public Human GetHuman()
    {
        return human;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Builder Pattern Example");

        IHumanBuilder builder = new HumanBuilder();
        builder.SetName("John");
        builder.SetAge(30);
        builder.SetGender("Male");

        Human human = builder.GetHuman();
        human.Introduce();
    }
}
