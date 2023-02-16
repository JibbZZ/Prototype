namespace ProtoTypePattern
{

    internal class Program
    {
        private static void Main(string[] args)
        {
        List <string> options = new List<string>() {"Leather Seats", "Sunroof", "Navigation"};
        Car c1 = new Car("Ford", "Mustang", 2019, options);
        Car c2 = c1.Clone() as Car;
        }
    }
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Car : Prototype
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public List<string> Options { get; set; }

        public Car(string make, string model, int year, List<string> options)
        {
            Make = make;
            Model = model;
            Year = year;
            Options = options;
        }
        public override Prototype Clone()
        {
            return new Car(Make, Model, Year, Options);
        }
    }
}