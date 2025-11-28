namespace DesignPattern.Factory
{
    public class OracleDatabase : IDatabase
    {
        public void ProcessQuery(string query)
        {
            Console.WriteLine($"Oracle processing: {query}");
        }
    }
}