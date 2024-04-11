﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public static void Execute()
        {
            //IDatabase database = new DatabaseProxy(() => new Database());
            //IDatabase database = new Database();
            //database = new DatabaseCacheProxy(database);


            IDatabase database = new DatabaseCacheProxy(new DatabaseProxy(() => new Database()));

            for (int i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (int i = 1; i < 11; i++)
            {
                Thread.Sleep(250);
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();
        }
    }
}