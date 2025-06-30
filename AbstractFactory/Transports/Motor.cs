

namespace AbstractFactory.Transports
{
    internal class Motor : ITransport
    {
        public void Deliver() => Console.WriteLine("Delivering by Motor 🚗");
    }

}
