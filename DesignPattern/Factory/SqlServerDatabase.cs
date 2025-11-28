namespace DesignPattern.Factory
{
    public class SqlServerDatabase : IDatabase
    {
        public void ProcessQuery(string query)
        {
            Console.WriteLine($"SQL Server processing: {query}");
        }
    }
}