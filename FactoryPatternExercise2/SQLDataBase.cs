namespace FactoryPatternExercise2;

public class SQLDataBase : IDataAccess
{
    public List<Product> ReadData()
    {
        Console.WriteLine("I am reading from the SQL Database...");
        Console.WriteLine();
        return new List<Product>()
        {
            new Product()
            {
                Name = "Product One SQL", Price = 122
            },
            new Product()
            {
                Name = "Product Two SQL", Price = 214
            }
        };  
    }

    public void WriteData()
    {
        Console.WriteLine("I am saving data to the SQL Database...");
    }
}