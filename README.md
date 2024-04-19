Factory Design Pattern - Logger Example
Overview:
This repository contains an example implementation of the Factory Design Pattern in C#. The Factory Design Pattern is a creational pattern that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. In this example, we create different types of loggers (Console Logger and File Logger) based on user input.

Files:
-Program.cs: Contains the main program logic where we demonstrate the Factory Design Pattern by creating different types of loggers.
-ILogger.cs: Defines the ILogger interface, which serves as the product interface for our loggers.
-ConsoleLogger.cs: Implements the ILogger interface for logging messages to the console.
-FileLogger.cs: Implements the ILogger interface for logging messages to a file.

How to Use:

1-Clone this repository to your local machine.
2-Open the solution in your preferred C# IDE (e.g., Visual Studio, Rider, etc.).
3-Build the solution to ensure all dependencies are resolved.
4-Run the 'Program.cs' file to see the Factory Design Pattern in action.

Usage Example:

ILogger logger;

// Create a Console Logger
logger = LoggerFactory.CreateLogger("console");
logger.Log("This is a console log!");

// Create a File Logger (log.txt)
logger = LoggerFactory.CreateLogger("file");
logger.Log("This message is written to a file.");


Adding New Logger Types:
To add new logger types (e.g., Database Logger, Cloud Logger), follow these steps:
1-Create a new class that implements the 'ILogger' interface.
2-Modify the 'LoggerFactory' class to include a case for the new logger type in the 'CreateLogger' method.
3-Update the Main method in 'Program.cs' to use the new logger type.

License
This code is provided under the MIT License. See LICENSE for details.

