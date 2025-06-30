﻿

namespace AbstractFactory.Tracks
{
    public class SatelliteTracker : ITracker
    {
        public void Track() => Console.WriteLine("Tracking with Satellite Tracker 🛰️");
    }
}
