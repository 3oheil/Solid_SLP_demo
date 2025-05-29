namespace Correc_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>
        {
            new Eagle(),
            new Ostrich()
        };

            foreach (var bird in birds)
            {
                bird.Eat();
            }

            List<IFyable> flyingBirds = new List<IFyable>
        {
            new Eagle()
            // Ostrich is not here
        };

            foreach (var flyer in flyingBirds)
            {
                flyer.Fly(); // فقط پرنده‌هایی که واقعاً می‌تونن پرواز کنن
            }
        }
    }
}
