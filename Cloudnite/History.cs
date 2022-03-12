namespace Cloudnite;
// Output the start screen saver
public static class History
{
    public static void Start()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|---------------------------------------------------------|");
        Console.ResetColor();Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to the Cloudnite game");
        Console.WriteLine("Select the mode in which you want to play");
        Console.WriteLine("1) Man vs. Man");
        Console.WriteLine("2) Man vs. Machine");
        Console.WriteLine("3) Machine vs. Machine");
        Console.ResetColor();Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|---------------------------------------------------------|");
        Console.ResetColor();Console.ResetColor();
    }
}