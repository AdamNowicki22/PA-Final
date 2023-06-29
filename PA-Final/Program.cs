namespace PA_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermarket Sklepik = new Supermarket();

            DateTime dateTime = new DateTime(2023, 8, 8);
            DateTime dateTime2 = new DateTime(2023, 6, 8);


            Trucks Ford1 = new Trucks("Ford", 5000.99f, 4, true);
            Milk mleczko = new Milk("Asda", 5.99f, dateTime);
            Milk stareMleko = new Milk("Muller", 5.99f, dateTime2);

            Sklepik.AddProductToStore(Ford1);
            Sklepik.AddProductToStore(mleczko);
            Sklepik.AddProductToStore(stareMleko);
            Sklepik.PrintStockForSale();
            Sklepik.RemoveSourMilk();
            Console.WriteLine(Sklepik.CanIAffordEverything(5000f));
        }
    }

}