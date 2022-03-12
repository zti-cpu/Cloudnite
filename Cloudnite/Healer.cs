namespace Cloudnite;

public class Healer : Person
{
    // Selecting a weapon depending on the value received
    private int _weapon;
    public override int Weapon
    {
        set
        {
            if (value == 1)
            {
                NameWeapon = "Holywater";
                _weapon = value;
            }
            else {
                NameWeapon = "Сross";
                _weapon = value;
            }
        }
        get => _weapon;
    }
    // Redefining a special attack
    public override void SpecialAttack(Person person,  IEnumerable<Person> card1,IEnumerable<Person> enemy)
    {                
        Random rnd = new Random();
        int a = rnd.Next(0, 2);
        int b = rnd.Next(2, 4);
        foreach (var person1 in card1)
        {
            person1.Health += (((person.Attack)*a)/b);
        }
    }
}