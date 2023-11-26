public class Program
{
    static FlightManager flightManager = new FlightManager(10000); // You can set the desired maxSeats value

     static void Main(string[] args)
     {
         RunFlightMenu();
     }

     static void RunFlightMenu()
     {
         while (true)
         {
             Console.Clear();
             Console.WriteLine("*==XYZ Airlines Limited==*\n");

             Console.WriteLine("FLIGHT'S MENU");
             Console.WriteLine("Please select a choice from the menu below:");
             Console.WriteLine("1. Add Flight");
             Console.WriteLine("2. View Flights");
             Console.WriteLine("3. View a particular Flight");
             Console.WriteLine("4. Delete Flight");
             Console.WriteLine("5. Back to Main Menu\n");

             Console.WriteLine("Enter your choice: ");
             int choice = Convert.ToInt32(Console.ReadLine());

             switch (choice)
             {
                 case 1:
                     flightManager.AddFlightProcess();
                     break;
                 case 2:
                     flightManager.ViewFlightsProcess();
                     break;
                 case 3:
                     flightManager.ViewSpecificFlightProcess();
                     break;
                 case 4:
                     flightManager.DeleteFlightProcess();
                     break;
                 case 5:
                     Environment.Exit(0);
                     break;
                 default:
                     Console.WriteLine("Invalid choice. Please try again.");
                     break;
             }
         }
     }
}
