
namespace Cloudnite;
public static class Program
{
	public static void Main()
		
	{
		// Generating a deck of cards
		var cards = GenerateCard.Card(1);
		// Running the story 
		History.Start();
		// Choice of battle
		int action = Convert.ToInt32(Console.ReadLine());
		Console.Clear();
		string? nameFirst;
		string? nameSecond;
		switch (action)
		{
			// Man to man battle
			case 1:
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("|---------------------------------------------------------|");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Let the epic battle between the two giants begin");
				Console.WriteLine("The first player to choose a name");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Yellow;

				Console.WriteLine("|---------------------------------------------------------|");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Green;
				// Choosing the name of the first character
				nameFirst = Console.ReadLine();

				Console.WriteLine("The Second player to choose a name");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("|---------------------------------------------------------|");
				Console.ResetColor();
				Console.ResetColor();
				// Choosing a second character's name
				nameSecond = Console.ReadLine();
				Console.Clear();
				// Until all the characters die, the game will continue
				while (SurvivorCount.Count(cards.card1) > 0 || SurvivorCount.Count(cards.card2) > 0)
				{
					Console.WriteLine("{0} player choose a character", nameFirst);
					// First Character Card Selection
					int remainingСards = Remaining.Renaiming(cards.card1, 1, nameFirst);
					// Second Character Card Selection
					Console.WriteLine("{0}Second player choose a character", nameSecond);
					int remainingCards1 = Remaining.Renaiming(cards.card2, 1, nameSecond);
					Console.Clear();
					// The battle of the two cards
					Battle.Move(cards.card1[remainingСards], cards.card2[remainingCards1], 1, 1, cards.card1,
						cards.card2);
				}
				// The conclusion of the victory
				if (SurvivorCount.Count(cards.card1) == 0 && SurvivorCount.Count(cards.card2) == 0)
				{
					Console.WriteLine("Both lost.");
				}
				else if (SurvivorCount.Count(cards.card1) == 0)
				{
					Console.WriteLine("{0} Was completely destroyed", nameFirst);
				}
				else
				{
					Console.WriteLine("{0} Was completely destroyed", nameSecond);
				}

				break;
			// Battle between man and bot
			case 2:
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("|---------------------------------------------------------|");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Let the epic battle between Man and Machine begin");
				Console.WriteLine("The first player to choose a name");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("|---------------------------------------------------------|");
				Console.ResetColor();
				Console.ResetColor();
				// First Character Card Selection
				nameFirst = Console.ReadLine();
				Console.WriteLine("The Second player to choose a name");
				nameSecond = "Robot";
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.ResetColor();
				Console.ResetColor();
				Console.Clear();
				while (SurvivorCount.Count(cards.card1) > 0 || SurvivorCount.Count(cards.card2) > 0)
				{
					Console.WriteLine("{0} player choose a character", nameFirst);
					// First Character Card Selection
					int remainingСards = Remaining.Renaiming(cards.card1, 1, nameFirst);
					Console.WriteLine("{0}Second player choose a character", nameSecond);
					// Second Character Card Selection
					int remainingСards1 = Remaining.Renaiming(cards.card2, 2, nameSecond);
					Console.Clear();
					// The battle of the two cards
					Battle.Move(cards.card1[remainingСards], cards.card2[remainingСards1], 1, 2, cards.card1,
						cards.card2);
				}
				// The conclusion of the victory

				if (SurvivorCount.Count(cards.card1) == 0 && SurvivorCount.Count(cards.card2) == 0)
				{
					Console.WriteLine("Both lost.");
				}
				else if (SurvivorCount.Count(cards.card1) == 0)
				{
					Console.WriteLine("{0} Was completely destroyed", nameFirst);
				}
				else
				{
					Console.WriteLine("{0} Was completely destroyed", nameSecond);
				}

				break;
			// Fighting a bot with a bot
			case 3:
				Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("|---------------------------------------------------------|");
					Console.ResetColor();
					Console.ResetColor();
					Console.WriteLine("Let the battle between the two machines begin");
					Console.WriteLine("Let the epic battle between Man and Machine begin");
					Console.WriteLine("The first player to choose a name");
					nameFirst = "Robot1";
					Console.WriteLine("The Second player to choose a name");
					nameSecond = "Robot2";
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("|---------------------------------------------------------|");
					Console.ResetColor();
					Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Clear();
					while (SurvivorCount.Count(cards.card1) > 0 || SurvivorCount.Count(cards.card2) > 0)
					{
						Console.WriteLine("{0} player choose a character", nameFirst);
						int remainingСards = Remaining.Renaiming(cards.card1, 2, nameFirst);
						Console.WriteLine("{0}Second player choose a character", nameSecond);
						int remainingСards1 = Remaining.Renaiming(cards.card2, 2, nameSecond);
						Console.Clear();
						Battle.Move(cards.card1[remainingСards], cards.card2[remainingСards1], 2, 2, cards.card1,
							cards.card2);
					}

					if (SurvivorCount.Count(cards.card1) == 0 && SurvivorCount.Count(cards.card2) == 0)
					{
						Console.WriteLine("Both lost.");
					}
					else if (SurvivorCount.Count(cards.card1) == 0)
					{
						Console.WriteLine("{0} Was completely destroyed", nameFirst);

					}
					else
					{
						Console.WriteLine("{0} Was completely destroyed", nameSecond);
					}

				break;
		}
	}	
			
}
