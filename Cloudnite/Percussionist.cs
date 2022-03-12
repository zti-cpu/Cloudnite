namespace Cloudnite;

public class Percussionist : Person
{
    private int _weapon;
    // Selecting a weapon depending on the value received
    public override int Weapon
    {
        set
        {
            if (value == 1)
            {
                NameWeapon = "Bita";
                _weapon = value;
            }
            else {
                NameWeapon = "Axe";
                _weapon = value;
            }
        }
        get => _weapon;
    }
    // Redefining a special attack
    public override void SpecialAttack(Person person,  IEnumerable<Person> card1,IEnumerable<Person> card2Enemy)
    {                
        Random rnd = new Random();
        int a = rnd.Next(2, 4);
        int b = rnd.Next(0, 2);
        foreach (var person1 in card2Enemy)
        {
            person1.Health -= (((person.Attack)*b)/a);
        }
    }
}
