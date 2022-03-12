namespace Cloudnite;

public class Mag : Person
{
    // Selecting a weapon depending on the value received
    private int _weapon;
    public override int Weapon
    {
        set
        {
            if (value == 1)
            {
                NameWeapon = "Staff";
                _weapon = value;
            }
            else {
                NameWeapon = "Wand";
                _weapon = value;
            }
        }
        get => _weapon;
    }
    // Redefining a special attack
    public override void SpecialAttack(Person person,  IEnumerable<Person> card1,IEnumerable<Person> card2Enemy)
    {                
        Random rnd = new Random();
        int a = rnd.Next(0, 2);
        foreach (var person1 in card1)
        {
            person1.Health += ((person.Attack)*a);
        }
        a = rnd.Next(0, 2);
        foreach (var person1 in card2Enemy)
        {
            person1.Health -= ((person.Attack)*a);
        }
    }
}


            