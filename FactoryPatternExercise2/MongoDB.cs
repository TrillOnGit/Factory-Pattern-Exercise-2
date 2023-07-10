namespace FactoryPatternExercise2;

public class MongoDB : IDataAccess
{
    public List<Product> ReadData()
    {
        Console.WriteLine("I am reading from the Mongo Database...");
        Console.WriteLine();
        
        return new List<Product>()
        {
            new Product()
            {
                Name = "Product One Mongo", Price = 122
            },
            new Product()
            {
                Name = "Product Two Mongo", Price = 214
            }
        };  
    }

    public void WriteData()
    {
        Console.WriteLine("I am saving data to the Mongo Database...");
    }
}