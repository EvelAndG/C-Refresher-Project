public class Card 
{
	public string Name {get; set;}
	public string Type {get; set;}
	int Number = 1;
	private static int numberCounter = 1;
	

	public override string ToString()
	{
		return "Name: "+ this.Name+"\n" + "Type: " + this.Type + "\n" + "Number: " + Number +"\n";
	}

  public Card()
	{
		Number = numberCounter++;
  
        
	}

	public Card(string cardName)
	{
		Name = cardName;
		Number = numberCounter++;
				

	}

	public Card(string cardName, string cardType) 
	{
		Name = cardName;
		Type = cardType;
		Number = numberCounter++;
		

	}

	public Card(string cardName, string cardType, int cardNumber)
	{
		Name = cardName;
		Type = cardType;
		Number = numberCounter++;
		
	}
	




 

}