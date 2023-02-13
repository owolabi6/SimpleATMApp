using System; 
public class cardHolder
{
    public string firstName;
    public string middleName;
    public string lastName;
    public string cardNum;
    public int pin;
    public double balance;

    public cardHolder(string firstName, string middleName,string lastName, string cardNum, int pin, double balance)
    {
        this.firstName = firstName;
        this.middleName = middleName;
        this.lastName = lastName;
        this.cardNum = cardNum;
        this.pin = pin;
        this.balance = balance;
    }
    public string getFirstName()
    {
        return firstName;
    }
    public string getMiddleName()
    {
        return middleName;
    }
    public string getLastName()
    {
        return lastName;
    }
    public string getCardNum()
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setFirstName(string newFirstName)
    {
        firstName =newFirstName;
    }
    public void setMiddleName(string newMiddleName)
    {
        middleName = newMiddleName;
    }
    public void setnewLastName(string newLastName)
    {
        lastName = newLastName;
    }
    public void setCardNum(string newCardNum)
    {
        cardNum = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }
    
}