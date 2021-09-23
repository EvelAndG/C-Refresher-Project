public class Card 
{
	public string Name;
	public string Type;
	public int Number;

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