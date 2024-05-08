using System;
using System.Collections.Generic;

namespace AbstractFactoryPatternExample
{
    // Abstract Product
    abstract class KitchenItem
    {
        public abstract string Print();
    }

    // Concrete Products
    class Spoon : KitchenItem
    {
        public override string Print() { return "Spoon"; }
    }

    class Pan : KitchenItem
    {
        public override string Print() { return "Pan"; }
    }

    class Glass : KitchenItem
    {
        public override string Print() { return "Glass"; }
    }

    // Abstract Factory
    abstract class KitchenFactory
    {
        public abstract KitchenItem CreateItem();
    }

    // Concrete Factory
    class SpoonFactory : KitchenFactory
    {
        public override KitchenItem CreateItem() { return new Spoon(); }
    }


    class PanFactory : KitchenFactory
    {
        public override KitchenItem CreateItem() { return new Pan(); }
    }

    class GlassFactory : KitchenFactory
    {
        public override KitchenItem CreateItem() { return new Glass(); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory Pattern Example");

            KitchenFactory factory = new SpoonFactory();
            KitchenItem item = factory.CreateItem();
            Console.WriteLine(item.Print());

            factory = new PanFactory();
            item = factory.CreateItem();
            Console.WriteLine(item.Print());

            factory = new GlassFactory();
            item = factory.CreateItem();
            Console.WriteLine(item.Print());
        }
    }
}
