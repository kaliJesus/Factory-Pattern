namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of car do you like to drive? Enter 1 for Motorcyle and 2 for Car");
            var answer = int.Parse(Console.ReadLine());
            IVehicle instance = VehicleFactory.GetVehicle(answer);
            instance.MyVehicle();
            Console.WriteLine("-----------");

            var cars = new Car();
            cars.MyVehicle();
            Console.WriteLine("-----------");
            var motorcycle = new Motorcycle();
            motorcycle.MyVehicle();

            

          
        }
    }
}
