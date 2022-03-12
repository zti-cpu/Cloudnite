namespace Cloudnite;

public class Remaining
{
    public static int Renaiming(Person[] card1, int who, string? nameSecond)
    {
        // Output the remaining cards
        List<int> list = new List<int>();
        int flag = 0;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|---------------------------------------------------------|");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var playears in card1)
        {
            if (playears.Health > 0)
            {
                Console.WriteLine("Select the remaining cards {1}) {0}", playears.Name, 
                    Array.IndexOf(card1, playears));
                list.Add(Array.IndexOf(card1, playears));
                flag += 1;
            }
        }
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("|---------------------------------------------------------|");
        Console.ResetColor();
        // If there are no cards left, you lose. 
        if (flag==0)
        {
            Console.Clear();
            Console.WriteLine("{0} Was completely destroyed",nameSecond);
            Environment.Exit(0);
        }
        // Card selection
        else
        {
            switch (who)
            {
                // If a person plays
                case 1 :
                    flag = Convert.ToInt32(Console.ReadLine());
                    return flag;
                // If a robot is playing
                case 2:
                    var b = list.ToArray();
                    Random rnd = new Random();
                    int number = rnd.Next(0, b.Length);
                    flag = b[number];
                    return flag;
            }
        }
        return flag;
    }
        
}