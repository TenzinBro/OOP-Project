 public class FlightManager
    {
        private int maxSeats;
        private int numPassengers;
        private Flight[] flightList;

       public FlightManager(int max)
      {
           numPassengers = 0;
           this.maxSeats = max;
           flightList = new Flight[max];
      }

public bool addFlight(int flightNumber, string origin, string destination)
{
    if (numPassengers < maxSeats)
    {
        flightList[numPassengers] = new Flight(flightNumber, origin, destination);
        numPassengers++;
        return true;
    }
    return false;
}

public bool deleteFlight(int flightNumber)
{
    int index = Search(flightNumber);
    if (index != -1)
    {
        for (int i = index; i < numPassengers - 1; i++)
        {
            flightList[i] = flightList[i + 1];
        }
        numPassengers--;
        return true;
    }
    return false;
}

private int Search(int flightNumber)
{
    for (int x = 0; x < numPassengers; x++)
    {
        if (flightList[x].getFlightNum() == flightNumber)
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

public void printAllFlights()
{
    for (int x = 0; x < numPassengers; x++)
    {
        Console.WriteLine(flightList[x].ToString());
    }
}
    }
