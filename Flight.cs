internal class Flight
{
    public int flightNumber;
    public string origin;
    public string destination;

    public Flight(int flightNumber, string origin, string destination)
    {
        this.flightNumber = flightNumber;
        this.origin = origin;
        this.destination = destination;
    }

    public int getFlightNum() { return flightNumber; }
    public string getOrigin() { return origin; }
    public string getDestination() { return destination; }

    public override string ToString()
    {
        string s = "Flight Number: " + flightNumber;
        s = s + "\nOrigin: " + origin;
        s = s + "\nDestination: " + destination;
        return s;
    }
}
