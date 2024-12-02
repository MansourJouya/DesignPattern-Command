using System;
using System.Collections.Generic;

/// <summary>
/// Command interface that defines an abstract execute method.
/// </summary>
public interface ICommand
{
    void Execute();
}

/// <summary>
/// Concrete command that encapsulates a specific action.
/// </summary>
public class ConcreteCommand : ICommand
{
    private readonly string _action;

    /// <summary>
    /// Initializes a new instance of the ConcreteCommand class.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    public ConcreteCommand(string action)
    {
        _action = action;
    }

    /// <summary>
    /// Executes the command's action.
    /// </summary>
    public void Execute()
    {
        Console.WriteLine($"Executing action: {_action}");
    }
}

/// <summary>
/// Invoker class that holds a command and triggers its execution.
/// </summary>
public class CommandInvoker
{
    private readonly List<ICommand> _commands = new List<ICommand>();

    /// <summary>
    /// Adds a command to the list.
    /// </summary>
    /// <param name="command">The command to be added.</param>
    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    /// <summary>
    /// Executes all commands in the list.
    /// </summary>
    public void ExecuteCommands()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }
}

/// <summary>
/// Client code demonstrating the use of the command pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Create concrete commands
        ICommand command1 = new ConcreteCommand("Turn on the lights");
        ICommand command2 = new ConcreteCommand("Play music");
        ICommand command3 = new ConcreteCommand("Start the coffee machine");

        // Create the invoker and add commands
        CommandInvoker invoker = new CommandInvoker();
        invoker.AddCommand(command1);
        invoker.AddCommand(command2);
        invoker.AddCommand(command3);

        // Execute all commands
        Console.WriteLine("Executing commands:");
        invoker.ExecuteCommands();
    }
}
