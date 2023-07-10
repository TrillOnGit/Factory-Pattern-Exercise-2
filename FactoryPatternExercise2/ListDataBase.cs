namespace FactoryPatternExercise2;

public class ListDataBase : IDataAccess
{
    public List<Product> ReadData()
    {
        Console.WriteLine("I am reading from the List Database...");
        Console.WriteLine();

        return new List<Product>()
        {
            new Product()
            {
                Name = "Product One List", Price = 122
            },
            new Product()
            {
                Name = "Product Two List", Price = 214
            }
        };  
    }

    public void WriteData()
    {
        Console.WriteLine("I am saving data to the List Database...");
    }
}