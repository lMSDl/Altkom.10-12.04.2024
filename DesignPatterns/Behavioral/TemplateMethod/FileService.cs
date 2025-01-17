﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.TemplateMethod
{
    internal class FileService : IDisposable
    {
        public FileService()
        {
            Console.WriteLine("Opening File.");
        }

        public void Dispose()
        {
            Console.WriteLine("Close File.");
        }

        public void Write(string message)
        {
            Console.WriteLine("Appending Log message to file : " + message);
        }
    }
}
