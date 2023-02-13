
using System.Linq;
using System;
namespace RevisionApp
{
   public class Program
    {
        static double Add (int a, int b)
        {
           return  a * b;
        }
        static double Add(double a, double b, double c)
        {
            return a * b * c;
        }
         static double Add(float a, float b, float c, float d)
         {
            float mult = a * b + c-d;
            return mult;
         }
         static double Add(decimal a, decimal b, decimal c, decimal d, decimal e)
         {
            
            decimal adding =  + b + c + d + e;
            double adding2 = Convert.ToDouble(adding);
            return adding2;
         }

         static void Odd(int intt)
         {
            for (int i = 0; i < 20; i++)
           {
             if (i %2 != 0)
             {
                Console.WriteLine(i);
             }
             
           }
         }
         static void FullName()
         {
            Console.WriteLine("Enter yor firstname: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine("My name is "+ name1 +" "+ name2 +".");
         }
        
         public string TimeConverter(string date)
         {
            double myNum = double.Parse(date.Substring(0,2));

            string result = "";
            if (date.Contains("PM"))
            {

                if(myNum > 12)
               {
                  double dateIn24Hours = myNum - 12;
                  result = $"{dateIn24Hours}{date.Substring(2,6)}";
               }
               if(myNum == 12)
            {
                result = $"{date.Substring(0,8)}";
            }
               else
               {
                  double dateIn24Hours = 12 + myNum;
                  result = $"{dateIn24Hours}{date.Substring(2,6)}";
               }
               return result;
              
               
            }
            if (date.Contains("AM"))
            {
               string t = "";
               double dateIn24Hours = 12 - myNum;
                if (Convert.ToInt32(dateIn24Hours) == 0)
               {
                   t ="00";
                 return result = $"{t}{date.Substring(2,6)}";
               }
               if (Convert.ToInt32(dateIn24Hours) <= 12)
               {
                   t ="0";
                 return result = $"{t}{Convert.ToInt32(myNum)}{date.Substring(2,6)}";
               }else{
                  t ="0";
                  return result = $"{t}{dateIn24Hours.ToString()}{date.Substring(2,6)}";
               }
               
            }
            return result;

         }
         
         static void Price()
         {
             int priceEdge = 10000;
            Console.WriteLine("Enter price: ");
            int price = int.Parse(Console.ReadLine());
            if (price > priceEdge)
            {
               int minus = price - priceEdge;
               Console.WriteLine($"The price is {minus} times greater than the Price-limit");
            }
            else
            {
               int remain = priceEdge - price;
               Console.WriteLine($"It remains {remain} hit the Price-Limit.");
            }
         }

         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            
            
            var timeCode = new Program();
            Console.WriteLine("Enter your time(hh,mm,ss): ");
            var timekey = Console.ReadLine();
            var result = timeCode.TimeConverter(timekey);

            Console.WriteLine(result);

         
           
          //Price();

            var meal1= new Test();

            double myInt = Add(6,4);
            double myDou = Add(2,3,4);
            double myDoub = Add(1,2,3,4);
            double myDoubl = Add(1,2,3,4,5);
            Console.WriteLine($"myInt is: {myInt}\nMyDou is: {myDou}\nMyDoub: {myDoub}\nMyDoubl is: {myDoubl}", + myInt,myDou,myDoub,myDoubl);
            
            FullName();
            meal1.MealCost(2,20,4);


            var nissan = new Car();
            nissan.brand = "Nissan";
            nissan.model = "XTERA";
            nissan.color = "red";
            nissan.speed = 220;
            nissan.year = 2011;
            Console.WriteLine($"That {nissan.color} car is a {nissan.brand} {nissan.model} {nissan.year} model,it has a top speed of {nissan.speed}Kmhr");

            var testfligt = new Test();
            testfligt.Engine();
            testfligt.Weigtht();
            testfligt.Speed(); 

            
        }
    }
}

