﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class Client
    {
        public static void Execute()
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Message to Log in File.");
            Console.WriteLine();
            EmailLogger emailLogger = new EmailLogger();
            emailLogger.Log("Message to Log via Email.");
            Console.WriteLine();
            DbLogger databaseLogger = new DbLogger();
            databaseLogger.Log("Message to Log in DB.");
        }
    }
}
