namespace Hospital.App.DAL;

public abstract class FileContext
{
    protected readonly string PathToDoctors;
    protected readonly string PathToPatients;

    protected FileContext(string pathToDoctors, string pathToPatients)
    {
        PathToDoctors = pathToDoctors;
        PathToPatients = pathToPatients;
    }
}