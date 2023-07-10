namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, which database would you like to access? Mongo, SQL, or a list?");
            var userDatabase = Console.ReadLine();

            IDataAccess database = DataAccessFactory.CheckAccess(userDatabase);
            List<Product> products = database.ReadData();
            database.WriteData();

            foreach (var product in products)
            {
                Console.WriteLine($"Product name: {product.Name}... Price: {product.Price}");
            }
        }
    }
}
