using System;
using System.Collections.Generic;
 
static class Game 
{
	public static string Name ="Stone Age";
	public static List<Card> cards = new List<Card>();
	public static List<Resource> resources = new List<Resource>();

	public static void AddCard(string name, string type)
	{
		Console.WriteLine("Please Enter a card name: ");
		string newName = Console.ReadLine();

		Console.WriteLine("Please Enter a type: ");
    string newType = Console.ReadLine();

		Card newCard = new Card(newName,newType);

		Console.WriteLine(newCard);

		cards.Add(newCard);

    foreach(Card card in cards)
	{
      Console.WriteLine(card);
    }

	}
	

}
