public class Program 
{
    static void addFlightProcess()
    {
        int flightNumber;
        string origin , destination;
        Console.Clear();
        Console.WriteLine("Enter the Flight Number: ");
        flightNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Origin of the Flight: ");
        origin = Console.ReadLine();
        Console.WriteLine("Enter the Destination of the Flight: ");
        destination = Console.ReadLine();
    }

    static void flightMenu()
    {
        Console.Clear();
        Console.WriteLine("***Flight List***");
        Console.WriteLine(" 1. Add FLight");
        Console.WriteLine(" 2. View Flights")
        Console.WriteLine(" 3. View Specific Flight");
        Console.WriteLine(" 4. Delete Flight");
        Console.WriteLine(" 5. Exit");
    }

    static void Main(string[] args)
    {

    }
}
