// Main class, from which all other card classes are inherited

namespace Cloudnite
{ 
	public class Person
	{
		public int Attack;
		public int Armor;
		public virtual int Weapon {
			set => Weapon = value; // Weapon inheritance fields
			get => Weapon;
		}
		
		public int Health;
		public string NameWeapon;
		public  string Name;
		protected  Person()
		{
			Attack = 1;
			Armor = 1;
			Health = 1;
			NameWeapon = "hand";
			Name = "People";

		}
		//Special attack
		public virtual void SpecialAttack(Person person, IEnumerable<Person> card1,IEnumerable<Person> cardenemy)
		{
			person.Health -= ((person.Attack));
		}
	}

}

