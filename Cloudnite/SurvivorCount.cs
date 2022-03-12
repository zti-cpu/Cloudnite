namespace Cloudnite;

// Counting the number of remaining cards
public static class SurvivorCount
{
    public static int Count(Person[] card1)
    {
        int count = 0;
        foreach (var playears in card1)
        {
            if (playears.Health > 0)
            {
                count += 1;
            }
        }
            
        return count;
    }
}