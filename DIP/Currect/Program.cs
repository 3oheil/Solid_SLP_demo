public interface IBeverageStation
{
    void MakeDrink();
}

public class CoffeeOrderSystem
{
    private IBeverageStation beverageStation;

    public CoffeeOrderSystem(IBeverageStation station)
    {
        beverageStation = station;
    }

    public void ProcessOrder()
    {
        beverageStation.MakeDrink();
    }
}

public class EspressoMachine : IBeverageStation
{
    public void MakeDrink()
    {
        Console.WriteLine("Making coffee...");
    }
}

public class TeaMaker : IBeverageStation
{
    public void MakeDrink()
    {
        Console.WriteLine("Making tea...");
    }
}
