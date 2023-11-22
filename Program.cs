public class Program
{
    static FlightManager flightManager;

    static void addFlightProcess()
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

        bool success = flightManager.addFlight(flightNumber, origin, destination);
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

    static void viewFlightsProcess()
    {
        Console.Clear();
        Console.WriteLine("*** Flight List ***");
        flightManager.printAllFlights();
        Console.ReadLine();
    }

    static void viewSpecificFlightProcess()
    {
        Console.Clear();
        Console.WriteLine("Enter the Flight Number: ");
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        Flight flight = flightManager.findFlight(flightNumber);
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

    static void deleteFlightProcess()
    {
        Console.Clear();
        Console.WriteLine("Enter the Flight Number: ");
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        bool success = flightManager.deleteFlight(flightNumber);
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

    static void flightMenu()
    {
        Console.Clear();
        Console.WriteLine("*** Flight List ***");
        Console.WriteLine(" 1. Add Flight");
        Console.WriteLine(" 2. View Flights");
        Console.WriteLine(" 3. View a specific flight");
        Console.WriteLine(" 4. Delete Flight");
        Console.WriteLine(" 5. Exit");
    }

    static void Main(string[] args)
    {
        flightManager = new FlightManager(10);
        int choice = 0;
        while (choice != 5)
        {
            flightMenu();
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    addFlightProcess();
                    break;
                case 2:
                    viewFlightsProcess();
                    break;
                case 3:
                    viewSpecificFlightProcess();
                    break;
                case 4:
                    deleteFlightProcess();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
