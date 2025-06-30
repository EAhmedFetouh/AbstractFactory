
using AbstractFactory.Documents;
using AbstractFactory.Tracks;
using AbstractFactory.Transports;

namespace AbstractFactory.Factories
{
    public class TruckLogisticFactory : ILogisticFactory
    {
        public ITransport CreateTransport() => new Truck();

        public IReceit CreateReceit() => new OfficialReceit();

        public ITracker CreateTracker() => new SatelliteTracker();
    }
}
