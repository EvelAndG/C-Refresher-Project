using System;

class MainClass {
  public static void Main (string[] args) {
    
    double totalCost = 100.2786753;

    Console.WriteLine(String.Format("{0:C}", totalCost));

    Console.WriteLine(String.Format("{0:F2}", totalCost));
		

   // Card card2 = new Card("banana","cool type",7);

	 Resource resource1 = new Resource("fine wood", "beige", 100);

		Card card3 = new Card();

  

		Console.WriteLine(resource1.ToString());

   
  }
}