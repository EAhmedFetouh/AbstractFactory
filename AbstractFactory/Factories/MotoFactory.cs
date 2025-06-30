

using AbstractFactory.Documents;
using AbstractFactory.Tracks;
using AbstractFactory.Transports;

namespace AbstractFactory.Factories
{
    public class MotoFactory : ILogisticFactory
    {
        public ITransport CreateTransport() => new Motor();

        public IReceit CreateReceit() => new PaperReceit();

        public ITracker CreateTracker() => new RoadCameraTracker();
    }
}
