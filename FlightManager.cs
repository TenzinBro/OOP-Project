 public class FlightManager
    {
        private int maxSeats;
        private int numPassengers;
        private Flight[] flightList;

        public FlightManager(int max) 
        {
            numPassengers = 0;
            this.maxSeats = max;
            flightList = new Flight[max]
        }

        public bool addFlight(int flightNumber, string origin, string destination)
        {
            if(numPassengers<maxSeats)
            {
                flightList[numPassengers] = new Flight(flightNumber, origin, destination);
                numPassengers++;
                return true;
            }
            return false;
        }

        public bool deleteFlight(int flightNumber, string origin, string destination)
        {
            if(numPassengers>maxSeats)
            {
                flightList[numPassengers] = new Flight(flightNumber, origin, destination);
                numPassengers--;
                return true;
            }
            return false;
        }

        private int Search(int flightNumber)
        {
            for (int x=0;x<numPassengers;x++)
            {
                if (flightListList[x].getFlightNum() == flightNumber)
                {
                    return x;
                }
            }
            return -1;
        }

        public Flight findFlight(int flightNumber)
        {
            int find = Search(flightNumber);
            if (find != -1)
            {
                return flightList[find];
            }
            return null;
        }

        public int printFoundFlight()
        {
            int find = Search(flightNumber);
            if (find != -1)
            {
                return flightList[find].ToString();
            }
            return null;
        }

        public override int printAllFlights()
        {
            string s = "--- Flight List ---";
            for (int x = 0; x < numPassengers; x++)
            {
                s=s+"\n" + flightList[x].ToString();
            }
            return s;
        }
    }
