internal class FlightManager
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

    public bool AddFlight(int flightNumber, string origin, string destination)
    {
        if (numPassengers < maxSeats)
        {
            flightList[numPassengers] = new Flight(flightNumber, origin, destination);
            numPassengers++;
            return true;
        }
        return false;
    }

    public bool DeleteFlight(int flightNumber)
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

    public Flight FindFlight(int flightNumber)
    {
        int find = Search(flightNumber);
        if (find != -1)
        {
            return flightList[find];
        }
        return null;
    }

    public void PrintAllFlights()
    {
        for (int x = 0; x < numPassengers; x++)
        {
            Console.WriteLine(flightList[x].ToString());
        }
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

    public void AddFlightProcess()
    {
        int flightNumber;
        string origin, destination;
        Console.Clear();
        Console.WriteLine("Enter the Flight Number: ");
        flightNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Origin of the Flight: ");
        origin = Console.ReadLine();
        Console.WriteLine("Enter the Destination of the Flight: ");
        destination = Console.ReadLine();

        bool success = AddFlight(flightNumber, origin, destination);
        if (success)
        {
            Console.WriteLine("Flight added successfully!");
        }
        else
        {
            Console.WriteLine("Failed to add flight. Maximum capacity reached.");
        }
        Console.ReadLine();
    }

    public void ViewFlightsProcess()
    {
        Console.Clear();
        Console.WriteLine("*** Flight List ***");
        PrintAllFlights();
        Console.ReadLine();
    }

    public void ViewSpecificFlightProcess()
    {
        Console.Clear();
        Console.WriteLine("Enter the Flight Number: ");
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        Flight flight = FindFlight(flightNumber);
        if (flight != null)
        {
            Console.WriteLine(flight.ToString());
        }
        else
        {
            Console.WriteLine("Flight not found.");
        }
        Console.ReadLine();
    }

    public void DeleteFlightProcess()
    {
        Console.Clear();
        Console.WriteLine("Enter the Flight Number: ");
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        bool success = DeleteFlight(flightNumber);
        if (success)
        {
            Console.WriteLine("Flight deleted successfully!");
        }
        else
        {
            Console.WriteLine("Failed to delete flight. Flight not found.");
        }
        Console.ReadLine();
    }
}
