public class Vehicle
{
    public string Name;
    public int NumPassengers;
    public string Color;
    public bool HasEngine;
    public int Distance = 0;

    public Vehicle(string n, int np, string c, bool he)
    {

        Name = n;
        NumPassengers = np;
        Color = c;
        HasEngine = he;
    }


    public Vehicle(string n, string c)
    {

        Name = n;
        NumPassengers = 5;
        Color = c;
        HasEngine = true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Number of Passengers: {NumPassengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Has an Engine: {HasEngine}");
        Console.WriteLine($"Distance: {Distance}");
    }

    public void Travel(int dist)
    {

        Distance+=dist;
        Console.WriteLine($"{Name} has now traveled {Distance}");
    }

}