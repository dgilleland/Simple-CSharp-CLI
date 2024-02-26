// See https://aka.ms/new-console-template for more information
namespace MyApp; // The modern way of doing a namespace

using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        Clear();
        WriteLine("Hello, World!");
        string terminalInput = string.Join("<burp>", args);
        WriteLine($"A special hello to {terminalInput}");
    }
}
