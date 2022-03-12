namespace Cloudnite
{

    public static class Battle
    {

        public static void Move(Person person1, Person person2, int who1, int who2,Person[] card, Person[] card2Enemy)

        {
            if (person1.Health > 0 && person2.Health > 0)
            {

                PersonPrint.PrintStats(person1, person2);

                Random rnd = new Random();
                int number = rnd.Next(1, 3);
                if (number == 1)
                {

                    PlayerAction.SelectAction(PlayerAction.Choice(who1), person1, card,card2Enemy);
                    PlayerAction.SelectAction(PlayerAction.Choice(who2), person2,card,card2Enemy);
                }

                else
                {
                    PlayerAction.SelectAction(PlayerAction.Choice(who1), person2,card,card2Enemy);
                    PlayerAction.SelectAction(PlayerAction.Choice(who2), person1,card,card2Enemy);

                }
            }
            else if (person1.Health <= 0)
            {
                Console.WriteLine("Character died {0}", person1.Name);
            }
            else if (person2.Health <= 0)
            {
                Console.WriteLine("Character died {0}", person2.Name);
            }

            Console.Clear();
        }


    }
}