public class Card 
{
	public string Name;
	public string Type;
	public int Number;

	public override string ToString()
	{
		return "Name: "+ this.Name+"\n" + "Type: " + this.Type + "\n" + "Number: " + this.Number +"\n";
	}

  public Card()
	{
        
	}

	public Card(string cardName)
	{
		Name = cardName;
		Type = "";
		Number = 0;

	}

	public Card(string cardName, string cardType, int cardNumber)
	{
		Name = cardName;
		Type = cardType;
		Number = cardNumber;
	}
	




 

}