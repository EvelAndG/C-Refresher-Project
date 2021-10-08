using System;
using System.Collections.Generic;
 
static class Game 
{
	public static string Name ="Stone Age";
	public static List<Card> cards = new List<Card>();
	public static List<Resource> resources = new List<Resource>();
	public static int resourceTotal;
	

	//Add Card Method
	public static void AddCard()
	{
		Console.WriteLine("Please Enter a card name: ");
		string newName = Console.ReadLine();

		Console.WriteLine("Please Enter a type: ");
    string newType = Console.ReadLine();

		Card newCard = new Card(newName,newType);

		cards.Add(newCard);

		Console.WriteLine("\n---Card Added---");

  

	}

		public static void AddResource()
	{
		Console.WriteLine("Please Enter a resource name: ");
		string newName = Console.ReadLine();

		Console.WriteLine("Please Enter a color: ");
    string newColor = Console.ReadLine();

		Console.WriteLine("Please Enter a quantity: ");
		string userQuantity = Console.ReadLine();
		int newQuantity = Int32.Parse(userQuantity);

		Resource newResource = new Resource(newName,newColor, newQuantity);


		resources.Add(newResource);
		Console.WriteLine("\n---Resource Added---"); 

  }

	//Game Report - In Progress
	public static void GameReport()
	{
		Console.WriteLine("\n-----"+Game.Name+"-----");

		//loop to print card list
		foreach(Card card in cards)
		{
      Console.WriteLine("---Card---\n"+card);
 		}
		foreach(Resource resource in resources)
		{
			Console.WriteLine("\n---Resource---\n"+resource);
		}

	}

	
	public static void FindCard(int i)
	{		
		Console.WriteLine(cards[i]);

	}

	public static void ResourceTotal()
	{
		
		foreach(Resource resource in resources)
		{
		resourceTotal += resource.Quantity;
		Console.WriteLine("\nResource Quantity Total: "+resourceTotal);
		}


	}
	

}
