namespace Cloudnite;
// Creating a card array for a character and his opponent
public class GenerateCard
{
    
    public static (Person[] card1, Person[] card2) Card( int levl)
    {
        // Generating a Servicewide Map
        Person[] playears = new Person[8];
        for (int counter = 0; counter < 8; counter++)
        {
            Random rand = new Random();
            int a = rand.Next(1, 5);
            int attack;
            int armor;
            int health;
            int wapon;
            switch (a)
            {
                case 1:
                    attack = rand.Next(5, 10)*levl;
                    armor = rand.Next(8, 12)*levl;
                    health = rand.Next(12, 15)*levl;
                    playears[counter] = new Fighter();
                    playears[counter].Name = "fighter";
                    playears[counter].Attack = attack;
                    playears[counter].Armor = armor;
                    playears[counter].Health = health;
                    wapon = rand.Next(1, 3);
                    playears[counter].Weapon = wapon;
                    break;
                case 2:
                    attack = rand.Next(4, 9)*levl;
                    armor = rand.Next(5, 7)*levl;
                    health = rand.Next(15, 22)*levl;
                    playears[counter] = new Mag();
                    playears[counter].Name = "Mag";
                    playears[counter].Attack = attack;
                    playears[counter].Armor = armor;
                    playears[counter].Health = health;
                    wapon = rand.Next(1, 3);
                    playears[counter].Weapon = wapon;
                    break;
                case 3:
                    health = rand.Next(16, 25)*levl;
                    attack = rand.Next(4, 7)*levl;
                    armor = rand.Next(5, 7)*levl;
                    playears[counter] = new Healer();
                    playears[counter].Name = "healer";
                    playears[counter].Attack = attack;
                    playears[counter].Armor = armor;
                    playears[counter].Health = health;
                    wapon = rand.Next(1, 3);
                    playears[counter].Weapon = wapon;

                    break;
                case 4:
                    health = rand.Next(10, 14)*levl;
                    attack = rand.Next(8, 12)*levl;
                    armor = rand.Next(8, 12)*levl;
                    playears[counter] = new Percussionist();
                    playears[counter].Name = "percussionist";
                    playears[counter].Attack = attack;
                    playears[counter].Armor = armor;
                    playears[counter].Health = health;
                    wapon = rand.Next(1, 3);
                    playears[counter].Weapon = wapon;

                    break;
            }
        }
        
        Person[] card1 =
        {
            playears[0], playears[1],
            playears[2], playears[3]
        };
        Person[] card2 =
        {
            playears[4], playears[5],
            playears[6], playears[7]
        };
        // Returns two decks of cards
        return (card1, card2);
    }
}