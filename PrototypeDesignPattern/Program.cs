using System;

namespace PrototypePatternExample
{
    abstract class BookingType
    {
        private string seat;

        public void SetSeat(string s) { seat = s; }
        public abstract BookingType Clone();
        public string GetSeat() { return seat; }
    }

    class Booking : BookingType
    {
        public override BookingType Clone()
        {
            return this.MemberwiseClone() as BookingType;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern Example");

            BookingType seat1 = new Booking();
            seat1.SetSeat("14b");
            Console.WriteLine(seat1.GetSeat());

            BookingType seat2 = seat1.Clone();
            Console.WriteLine(seat2.GetSeat());
        }
    }
}
