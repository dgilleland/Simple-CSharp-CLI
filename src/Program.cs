// See https://aka.ms/new-console-template for more information
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Hello, World!");
        string terminalInput = string.Join(',', args);
        WriteLine($"A special hello to {terminalInput}");
    }
}