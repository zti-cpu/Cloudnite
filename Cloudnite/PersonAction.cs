
namespace Cloudnite
{
    //Choice of player actions, without a special attack 
    public class PersonAction 
    {
        // Attacking a normal attack
        protected static void NormAttack(Person person)
        {
            if (person.Armor > 0)
            {
                person.Armor -= person.Weapon + person.Attack;
            }
            else
            {
                person.Health -= person.Weapon + person.Attack;
            }

        }
        // Attacking a normal random attack

        protected static void RandomAttack(Person person)
        {
            var rnd = new Random();
            int number = rnd.Next(1, 5);
            if ((person.Attack - number) <0)
            {
                person.Health -= 1;
            }
            else
            {
                person.Health -= ((person.Attack - number) * number);
            }
        }


        protected static void RegenerationHealth(Person person)
        {
            person.Health += ((person.Attack));
        }
        
        
    }

}