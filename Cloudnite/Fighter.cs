namespace Cloudnite;

public class Fighter : Person
{
    private int _weapon;
    // Selecting a weapon depending on the value received
    public override int Weapon
    
    {
        set
        {
            if (value == 1)
            {
                NameWeapon = "Sword";
                _weapon = value;
            }
            else {
                NameWeapon = "Excalibur";
                _weapon = value;
            }
        }
        get => _weapon;
    }
    // Redefining a special attack
    public override void SpecialAttack(Person person, IEnumerable<Person> card1,IEnumerable<Person> enemy)
    {                
        Random rnd = new Random();
        int a = rnd.Next(0, 4);
        person.Health -= ((person.Attack)*a);
    }
}