using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
	{
			int userInt = 0;
			int userNum = 0;

			

		while ( userInt != 7)
		{
		Console.WriteLine("\nWelcome to the Menu! \nPlease enter the corresponding number to make selection: \n");

		Console.WriteLine("1: Print Game Name \n2: Game Report \n3: Total of all Resources \n4: Find a card \n5: Add a Card \n6: Add a Resource \n7: Quit Program");

		string userSelection = Console.ReadLine();

		userInt = Convert.ToInt32(userSelection);

		if (userInt == 1)
		{
			Console.WriteLine("\n"+Game.Name);
		}


		if (userInt == 2)
		{
			Game.GameReport();
		}


		if (userInt == 3)
		{
			Console.WriteLine("\nResource total not implemented yet");
		}


		if (userInt ==4)
		{
			Console.WriteLine("Enter a number parameter to search: ");
			string userFindNum = Console.ReadLine();
				userNum = Convert.ToInt32(userFindNum);


			Game.FindCard(userNum);
		}


		if (userInt ==5)
		{
			Game.AddCard();
		}


		if (userInt ==6)
		{
			Resource.AddResource();
		}

		} //end of while loop


    
    //double totalCost = 100.2786753;

    //Console.WriteLine(String.Format("{0:C}", totalCost));

   // Console.WriteLine(String.Format("{0:F2}", totalCost));
		
		//Console.WriteLine(Game.Name);

		//Game.AddCard();

	//	Resource.AddResource();
   
  }
}