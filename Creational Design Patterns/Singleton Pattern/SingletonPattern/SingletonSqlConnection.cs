namespace SingletonPattern;

public sealed class SingletonSqlConnection
{
    private static SingletonSqlConnection? _singletonSqlConnection;
    private static readonly object _lock = new();

    public static SingletonSqlConnection Instance
    {
        get
        {
            lock (_lock)
            {
                return _singletonSqlConnection ??= new SingletonSqlConnection();
            }
        }
    }

    private SingletonSqlConnection()
    {
        Connect();
    }

    private void Connect()
    {
        Task.Delay(2000).Wait();
        Console.WriteLine("Connected to the database");
    }

    public void ExecuteAsync()
    {
        Task.Delay(500).Wait();
        Console.WriteLine("Query Executed.");
    }
}

