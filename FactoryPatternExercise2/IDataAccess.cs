namespace FactoryPatternExercise2;

public interface IDataAccess
{
    List<Product> ReadData();
    void WriteData();
}