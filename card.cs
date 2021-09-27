public class Card 
{
	public string Name {get; set;}
	public string Type {get; set;}
	static int Number = 1;
	

	public override string ToString()
	{
		return "Name: "+ this.Name+"\n" + "Type: " + this.Type + "\n" + "Number: " + Number +"\n";
	}

  public Card()
	{
        
	}

	public Card(string cardName)
	{
		Name = cardName;
		Type = "";
		
		

	}

	public Card(string cardName, string cardType, int cardNumber)
	{
		Name = cardName;
		Type = cardType;
		Number = cardNumber++;
	}
	




 

}