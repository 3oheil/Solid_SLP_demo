namespace violation_Example
{
    public class Program
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
                bird.Fly(); // برنامه اینجا برای Ostrich می‌ترکه
            }
        }
    }
}
