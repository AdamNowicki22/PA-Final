namespace PA_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermarket Sklepik = new Supermarket();

            DateTime dateTime = new DateTime(2023, 08, 8);

            Trucks Ford1 = new Trucks("Ford", 5000.99f, 4, true);
            Milk mleczko = new Milk("Asda", 5.99f, dateTime);

            Sklepik.AddProductToStore(Ford1);
            Sklepik.AddProductToStore(mleczko);
            Sklepik.PrintStockForSale();

            Console.WriteLine();
        }
    }

}