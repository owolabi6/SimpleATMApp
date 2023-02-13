using System.Net;
using System; // See https://aka.ms/new-console-template for more information
using System.IO;
public class program
{
   public static void Main(string[] args)
    {
        
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.CheckBalance");
            Console.WriteLine("4.Transfer");
            Console.WriteLine("5.Exit");
        }
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("Input the amount of Money you would like to deposit: ");
            double deposit= Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit );
            Console.WriteLine("Thank you for banking with us.Your current balance is "+ currentUser.getBalance());
        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("Input the amount of Money you would like to withddraw: ");
            double withdraw = Double.Parse(Console.ReadLine());
            if (currentUser.getBalance() < withdraw)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("Thank you for banking with us");
            }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: "+ currentUser.getBalance());
        }
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("Ismail","Waris","Ade","098765432109",4444,20000.78));
        cardHolders.Add(new cardHolder("Sam","Pal","Carl","654321789010",3421,67000.78));
        cardHolders.Add(new cardHolder("Jon","Bod","Wike","109283746556",0987,987600.78));
        cardHolders.Add(new cardHolder("Calik","Malik","Mulk","123456789009",1234,2000.78));

        // string filePath = @"C:\Demo\text.txt";
        // //string [] lines  =File.ReadAllLine(filePath);
        // List<string> lines =new List<string>();
        // lines = File.ReadAllLines(filePath).ToList();
        // foreach (string line in lines)
        // {
        //     Console.WriteLine(line);
        // }
        // lines.Add("Mile,Jack,Xi,102929011234,7890,4567.09");
        // File.WriteAllLines(filePath,lines);

        Console.WriteLine("Welcom to Malik SimpleATM 1.0");
        Console.WriteLine("Plese insert your debit card: ");
        string debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if(currentUser != null){break; }
                else{Console.WriteLine("Card not recognised. Please try again");}
            }
            catch (System.Exception)
            {
                Console.WriteLine("Card not recognised. Please try again");
                throw;  
            }
        }
        Console.WriteLine("Please enter your  pin");
        int userPin = 0;
         while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if(currentUser.getPin() == userPin){break; }
                else{Console.WriteLine("Incorrect pin. Please try again");}
            }
            catch (System.Exception)
            {
                Console.WriteLine("Incorrect pin. Please try again");
                throw;
            }
        }

        Console.WriteLine("Welcome "+currentUser.getFirstName());
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option =int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                
                throw;
            }
            if (option == 1)
            {
                deposit(currentUser);
            }
            else if(option == 2)
            {
                withdraw(currentUser);
            }
            else if(option == 3)
            {
                balance(currentUser);
            }
            // else if(option == 4)
            // {
            //     transfer(currentUser);
            // }
            else if(option == 5)
            {
                break;
            }
            else{option = 0;}
        } while (option != 4);
        Console.WriteLine("Thank you have a nice day");
    }
}

