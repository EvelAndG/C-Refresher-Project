using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
	{

    
    double totalCost = 100.2786753;

    Console.WriteLine(String.Format("{0:C}", totalCost));

    Console.WriteLine(String.Format("{0:F2}", totalCost));
		
		Console.WriteLine(Game.Name);

		Game.AddCard();

		Resource.AddResource();
   
  }
}