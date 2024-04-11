using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private IDatabase? _database;

        public DatabaseProxy(IDatabase database)
        {
            _database = database;
        }
        Func<IDatabase> _func;
        public DatabaseProxy(Func<IDatabase> func)
        {
            _func = func;
        }

        public const int MAX = 4;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(MAX);
        public async Task RequestAsync(int @int)
        {
            await semaphoreSlim.WaitAsync();
            if (_database == null)
            {
                _database = _func();
            }

            await _database.RequestAsync(@int);

            semaphoreSlim.Release();

            if (semaphoreSlim.CurrentCount == MAX)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            _database?.Dispose();
            _database = null;
        }
    }
}
