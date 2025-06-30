

using AbstractFactory.Documents;
using AbstractFactory.Tracks;
using AbstractFactory.Transports;

namespace AbstractFactory.Factories
{
    public interface ILogisticFactory
    {
        ITransport CreateTransport();
        IReceit CreateReceit();
        ITracker CreateTracker();
    }
}
