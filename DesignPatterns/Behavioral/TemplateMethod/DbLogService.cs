namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogService : IDisposable
    {
        public DbLogService()
        {
            Console.WriteLine("Connecting to Database.");
        }

        public void Dispose()
        {
            Console.WriteLine("Closing DB connection.");
        }

        public void Write(DbLog message)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + message.Message);
        }
    }
}