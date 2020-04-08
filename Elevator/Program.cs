using System;
using System.Collections.Generic;
using System.Text;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Floor zero = new Floor(0);
            Floor one = new Floor(1);
            Floor two = new Floor(2);
            Floor three = new Floor(3);
            Floor four = new Floor(4);
            Floor five = new Floor(5);
            Floor six = new Floor(6);
            Floor seven = new Floor(7);
            Floor eight = new Floor(8);
            Floor nine = new Floor(9);


            List<Floor> Levels = new List<Floor> { zero, one, two, three, four, five, six, seven, eight, nine };
            Elevator Otis = new Elevator(Levels, 10, 0);

            Passenger Adam = new Passenger(6);
            zero.AddPassenger(Adam);
            Otis.Drive(Levels, 6);
          
            
        }

    }
}
