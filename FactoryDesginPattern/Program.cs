using FactoryDesginPattern.After;

public class Program
{
    public static void Main()
    {
        ILogger logger;

        logger = LoggerFactory.CreateLogger("console");
        logger.Log("This is a console log!");

        logger = LoggerFactory.CreateLogger("file");
        logger.Log("This message is written to a file.");

        // The beauty of this approach is that the client code remains unchanged
        // even if we introduce new logger types in the future.

        Console.ReadKey();
    }
}