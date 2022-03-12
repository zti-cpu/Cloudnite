
namespace Cloudnite
{
    // Characterization output
    public static class PersonPrint
    {
        public static void PrintStats(Person person, Person person1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("|Hero name is: {0,6}| Enemy name is: {1,6}|", person.Name,person1.Name);
            Console.WriteLine("|Name weapon is: {0,6}| Name weapon is: {1,6}|",
                person.NameWeapon, person1.NameWeapon);
            Console.WriteLine("|---------------------------------------------------------|");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|Hero attack value is: {0,6}| Enemy attack value is: {1,6}|", person.Attack,
                        person1.Attack);
            Console.WriteLine("|Hero health value is: {0,6}| Enemy health value is: {1,6}|", person.Health,
                        person1.Health);
            Console.WriteLine("|Hero weapon value is: {0,6}| Enemy weapon value is: {1,6}|", person.Weapon,
                        person1.Weapon);
            Console.WriteLine("|Hero armor value  is: {0,6}| Enemy armor value  is: {1,6}|", person.Armor,
                person1.Armor);
            Console.WriteLine("");
            Console.ResetColor();
            }
        }

}