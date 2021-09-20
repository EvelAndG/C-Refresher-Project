using System;

class MainClass {
  public static void Main (string[] args) {
    
    double totalCost = 100.2786753;


    Console.WriteLine(String.Format("{0:C}", totalCost));

    Console.WriteLine(String.Format("{0:F2}", totalCost));
		
	Card myObj = new Card("bob", "bob", 5);
	Console.WriteLine(myObj.name);

	Resource myObj1 = new Resource("iron", "red", 100);
	Console.WriteLine(myObj1.name);
	}



}