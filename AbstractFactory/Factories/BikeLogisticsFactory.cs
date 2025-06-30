
using AbstractFactory.Documents;
using AbstractFactory.Tracks;
using AbstractFactory.Transports;

namespace AbstractFactory.Factories
{
    public class BikeLogisticsFactory : ILogisticFactory
    {
        public ITransport CreateTransport() => new Bike();
        public IReceit CreateReceit() => new DigitalReceit();
        public ITracker CreateTracker() => new GPSBikeTracker();
    }
  
}
