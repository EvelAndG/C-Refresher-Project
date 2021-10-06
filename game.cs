using System;
using System.Collections.Generic;
 
static class Game 
{
	public static string Name ="Stone Age";
	public static List<Card> cards = new List<Card>();
	

	//Add Card Method
	public static void AddCard()
	{
		Console.WriteLine("Please Enter a card name: ");
		string newName = Console.ReadLine();

		Console.WriteLine("Please Enter a type: ");
    string newType = Console.ReadLine();

		Card newCard = new Card(newName,newType);

		cards.Add(newCard);

    foreach(Card card in cards)
	{
      Console.WriteLine(card);
    }

	}

	//Game Report - In Progress
	public static void GameReport()
	{
		Console.WriteLine("\n"+Game.Name);

	}

	//Find Card Method - In Progress
	public static void FindCard(int i)
	{
		
		Console.WriteLine(cards[i]);
	

	}
	

}
