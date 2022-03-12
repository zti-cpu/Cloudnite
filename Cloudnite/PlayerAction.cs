namespace Cloudnite;

// Selecting an attack and outputting their completion
public class PlayerAction : PersonAction
{
    // Attack choice
    public static int Choice(int who)
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1) Norm Attack");
        Console.WriteLine("2) Random Attack");
        Console.WriteLine("3) Regeneration Health");
        Console.WriteLine("4) Special Attack");
        if (who == 1)
        {
            var flag = Convert.ToInt32(Console.ReadLine());
            return flag;
        }
        else
        {   Random rand = new Random();
            int flag = rand.Next(1, 5);
            return flag;
        }

    }
    // Outputting their completion
    public static void SelectAction(int flag, Person person, Person[] card1, Person[] card2Enemy)
    {
        if (flag == 1)
        {
            NormAttack(person);
            Console.WriteLine("You used a normal attack");
        }

        else if (flag == 2)
        {
            RandomAttack(person);
            Console.WriteLine("You used a random attack");
        }

        else if (flag == 3)
        {
            RegenerationHealth(person);
            Console.WriteLine("You have regained your health");
        }
        else
        {
            person.SpecialAttack(person, card1,card2Enemy);
            Console.WriteLine("You have regained your health");
        }

    }
}