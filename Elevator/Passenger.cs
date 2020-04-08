using System;
using System.Collections.Generic;
using System.Text;

namespace Elevator
{
    class Passenger
    {
        public int Destination { get; private set; }
        public Passenger(int _destination)
        {
            Destination = _destination;   
        }
    }
}
