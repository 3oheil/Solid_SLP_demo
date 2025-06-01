public class CoffeeOrderSystem
{
    private EspressoMachine espressoMachine = new EspressoMachine();

    public void ProcessOrder()
    {
        espressoMachine.MakeCoffee();
    }
}

public class EspressoMachine
{
    public void MakeCoffee()
    {
        Console.WriteLine("Making coffee...");
    }
}
