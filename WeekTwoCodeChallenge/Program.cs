using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the function and the number that you want
            FizzBuzz(12);
            // keep teh build open
            Console.ReadKey();
        }
        // creating the function
        static void FizzBuzz(int number)
        {
            // the if statement to see if the number that is inside the paramaters to the called fuction is fizz, buzz, or fizzbuzz
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                // if the if statment is false just print the number
                Console.WriteLine(number);
            }
			 
			}
        
        static void letterCounter( char letter, string InString)
        {

            char letter = letterCounter[i];
            
            char Upper = x;
            char Lower = y;
            for (int i = 0; i < letterCounter.length; i++)
			{
                if (x == letterCounter[i])
	{
		        Console.WriteLine(Upper);
	}
                if (y == letterCounter[i])
	{
		 Console.WriteLine(Lower);
	}
                if (x != letterCounter.length)
                {
	
		 Console.WriteLine();
                }
            }
        }
	
             
        
             
    }
}
			  static void TextStats(string input)
        {  
            // standardized

            input = input.ToLower();


            // number ofletters
            Console.WriteLine("Number of letters:" + input.Length);
            // number of vowels
            Console.WriteLine("number of vowels:" + input.Where( x => "aeiou".Contains(x)).Count());
            //number of consanats
            Console.WriteLine("Number of Cons.:" + input.Where( x => ! "aeiou".Contains(x)).Count());
            // number special char
            Console.WriteLine("Number of Special Char.:" + input.Where(x => ",. ?".Contains(x)).Count());
            // number of words
            Console.WriteLine("Number of words:" + input.Split(' ').Count));
            // shortest word
            Console.WriteLine("Shortest word:" + input.Split(" ").OrderBy(" ", ""));
            // longest word
            Console.WriteLine("Second longest word:" + input.Split(" ").OrderBy("",' '));
            //second longest word
            
            Console.WriteLine("Longest word:" + input.Split(" ").OrderBy(" ", " "));
			 
			}
	

		 
	
			 
			
       
	
    
            


        
        


            
        


       
			 
			
          



   


   
       
      




















