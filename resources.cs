public class Resource 
{
	public string Name;
	public string Color;
	public int Quantity;

	public Resource(string resourceName, string resourceColor, int resourceQuantity)
	{
		Name = resourceName;
		Color = resourceColor;
		Quantity = resourceQuantity;
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