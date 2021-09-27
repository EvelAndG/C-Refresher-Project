using System;

class MainClass {
  public static void Main (string[] args) {
    
    double totalCost = 100.2786753;

    Console.WriteLine(String.Format("{0:C}", totalCost));

    Console.WriteLine(String.Format("{0:F2}", totalCost));
		
		Console.WriteLine();
		

   // Card card2 = new Card("banana","cool type",7);

	 //Resource resource1 = new Resource("fine wood", "beige", 100);

		Card card1 = new Card ("bob", "rare");

		Card card2 = new Card ("charizard", "fire");

		Card card3 = new Card ("squirtle");

		Card card4 = new Card();


		Console.WriteLine(card1);
		Console.WriteLine(card2);
		Console.WriteLine(card3);
		Console.WriteLine(card4);

		Resource resource1 = new Resource("Core Wood", "Brown", 100);

		Console.WriteLine(resource1);

	



  

		

   
  }
}