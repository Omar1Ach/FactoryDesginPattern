using System;
using System.IO;

namespace WithoutFactoryDesignPattern
{
    // Define the Product Interface
    public interface ILogger
    {
        void Log(string message);
    }

    // Concrete Implementations for the Products
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console: " + message);
        }
    }

    public class FileLogger : ILogger
    {
        private string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            File.AppendAllText(_filePath, "File: " + message + Environment.NewLine);
        }
    }

    
}
