using System;
using System.Collections.Generic;


public class Resource 
{	
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


}