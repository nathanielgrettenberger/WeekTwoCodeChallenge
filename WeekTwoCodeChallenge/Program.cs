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
                if (x || y != letterCounter.length)
                {
	
		 Console.WriteLine();
                }
            }
        }
	
             static void TextStats( string input)
{
            string text = "it looks pretty crappy outside"; 
            /// declaring the text
                for (int i = 0; i < text.Length; i = i +1){
              ///
                    char letter = text[i];
                    if (letter == 'p')
                    {
                        Console.WriteLine("found a p");
                    }
                                   
                
                /// how to loop over each word in a string
                
                string text2 = "it looks pretty crappy outside";
                List<string> wordList = text2.Split(' ').ToList();
                for (int i = wordList.Count() - 1; i >= 0; i--)
                {
                        
                    Console.WriteLine(wordList[i] + " ");
                    
                }
                var longWord = "  ";
                var shortWord = " ";
                if (longWord == wordList[i])
                {
                    Console.WriteLine(longWord);
                }
                if (shorWord = wordlist[i])
                {
                    Console.WriteLine(shortWord);
                }
                
            Console.ReadKey();
        
        
     
    }
}
			
			 
			}
	

		 
	}
			 
			
       
	
    
            


        
        


            
        


       
			 
			
          



   


   
       
      




















