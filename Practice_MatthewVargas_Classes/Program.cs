namespace Practice_MatthewVargas_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Car class");

            Car myCar = new Car(); ;
            //know nothing about car models, chatgpt was able to help there :)
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2024;
            myCar.Color = "Hot Pink";
            myCar.Mileage = 1;


            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Color: {myCar.Color}");
            Console.WriteLine($"Mileage: {myCar.Mileage}");
            Console.WriteLine($"~--------------~"); //Sepearation for neatness when running
            //Start of next section regarding Bike class

            Console.WriteLine("Testing Bike Class");

            BikeInfo myBike = new BikeInfo();

            myBike.Brand = "Cascade";
            myBike.Color = "red";
            myBike.NumOfWheels = 2;
            myBike.Variation = BikeInfo.Type.mountain;


            Console.WriteLine($"Brand: {myBike.Brand}");
            Console.WriteLine($"Color: {myBike.Color}");
            Console.WriteLine($"Number of Wheels: {myBike.NumOfWheels}");
            Console.WriteLine($"Variation: {myBike.Variation}");

        }
    }
}
