using System;
using System.Collections.Generic;


public class Resource 
{

	public static List<Resource> resources = new List<Resource>();
	
	public string Name {get; set;}
	public string Color {get; set;}
	public int Quantity {get; set;}

	public override string ToString()
	{
		return "Name: "  + this.Name+"\n" + 
		"Color: " + this.Color + "\n" + "Qty: " + this.Quantity + "\n";
	}

	public Resource(string resourceName, string resourceColor, int resourceQuantity)
	{
		Name = resourceName;
		Color = resourceColor;
		Quantity = resourceQuantity;
	}

	public Resource(string resourceName, string resourceColor)
	{
		Name = resourceName;
		Color = resourceColor;
	}

	public Resource(string resourceName)
	{
		Name = resourceName;
		Color = "";
		Quantity = 0;
		
	}

	public Resource()
	{
		Name = "";
		Color = "";
		Quantity = 0;

	}

	public static void AddResource()
	{
		Console.WriteLine("Please Enter a resource name: ");
		string newName = Console.ReadLine();

		Console.WriteLine("Please Enter a color: ");
    string newColor = Console.ReadLine();

		Resource newResource = new Resource(newName,newColor);


		resources.Add(newResource);

    foreach(Resource resource in resources)
	{
      Console.WriteLine(resource);
    }

	}
	




 

}