namespace SingletonPattern;

public class SqlConnection
{
    public SqlConnection()
    {
        Connect();
    }

    private void Connect()
    {
        Task.Delay(2000)
            .Wait();

        Console.WriteLine("Connected to the database");
    }
    public void ExecuteAsync()
    {
        Task.Delay(500)
        .Wait();

        Console.WriteLine("Query Executed.");
    }
}

