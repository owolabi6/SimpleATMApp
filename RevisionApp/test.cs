using System;

namespace RevisionApp
{
    public class Test : IJet
    {
        public  void MealCost(decimal tip, decimal tax, decimal meal)
        {
            Console.WriteLine("Enter the precentage Price: ");
            decimal percentage = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Tip Price: ");
            decimal tipPercent = Convert.ToDecimal(Console.ReadLine());
            tip = tipPercent * percentage / 100;
            Console.WriteLine("Enter Tax price: ");
            decimal taxPercent = Convert.ToDecimal(Console.ReadLine());
            tax = taxPercent * percentage / 100;
            Console.WriteLine("Enter Meal: ");
            meal = Convert.ToDecimal(Console.ReadLine());
            decimal price = meal + tax + tip;

            Console.WriteLine($"The tip price is:{tip}\nThe tax price is:{tax}\nThe percentage price is:{percentage}\nThe Meal price is:{meal} \nThe TOTAL Price is:{price} Naira.");
           // return price;
        }

        public void  Engine()
        {
          Console.WriteLine("The jet Engine produce 12,345hp of trust");
        }

        public void  Weigtht()
        {
          Console.WriteLine("The jet weigth 12,000Kg");
        }

        public void Speed()
        {
          Console.WriteLine("The jet 12,345 horse power Engine is enough to hit mach 2.2 that is 2280Km an hour!");
        }
    }
}