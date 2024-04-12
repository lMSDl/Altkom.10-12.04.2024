using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class DbLogger : Logger<DbLog, DbLogService>
    {
        protected override void Save(DbLog item, DbLogService service)
        {
            service.Write(item);
        }

        protected override DbLog CreateItem(string message)
        {
            return new DbLog() { DateTime = DateTime.Now, Message = message };
        }

        protected override DbLogService GetService()
        {
            return new DbLogService();
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }
    }
}
