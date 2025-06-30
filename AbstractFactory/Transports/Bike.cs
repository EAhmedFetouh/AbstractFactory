

namespace AbstractFactory.Transports
{
    public class Bike : ITransport
    {
        public void Deliver() => Console.WriteLine("Delivering by Bike 🛵");
    }
}
