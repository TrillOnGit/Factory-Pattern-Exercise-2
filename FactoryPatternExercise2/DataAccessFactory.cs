namespace FactoryPatternExercise2;

public static class DataAccessFactory
{
    public static IDataAccess CheckAccess(string DBReq)
    {
        switch (DBReq.ToLower())
        {
            case "list" or "list database":
                return new ListDataBase();
            case "mongo" or "mongo database":
                return new MongoDB();
            case "sql" or "sql database":
                return new SQLDataBase();
            default:
                Console.WriteLine("Invalid input, returning SQLDataBase");
                return new SQLDataBase();
        }
    }
}