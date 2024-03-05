namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // create an object/instance
            Car myCar = new Car(); // any name instaed of myCar, Car(first one) is a type, can be used var for inferrred type
            myCar.Make = "Toyota";
            myCar.Year = 2022;
            myCar.Model = "Camry";

            // if want to pass just one value , don't need to use $ means(string interpolation)
            Console.WriteLine($"{myCar.Model} {myCar.Year} {myCar.Model}");
            
        }
    }
}
