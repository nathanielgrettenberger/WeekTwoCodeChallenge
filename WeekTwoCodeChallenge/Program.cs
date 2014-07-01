using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Code_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                //FizzBuzz(i);
            }
            //LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            //LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            //LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");
            TextStats("I'm enjoying code.");

            LetterCounter(hello);
            Console.ReadKey();
        }

        //Creating FizzBuzz function
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        //Creating LetterCounter function
        static void LetterCounter(char letter, string inString)
        {
            int totalLower = 0;
            int totalUpper = 0;
            int totalLetter = 0;
            var letterLower = letter.ToString().ToLower();
            var letterUpper = letter.ToString().ToUpper();
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == letterLower)
                {
                    totalLower++;
                    totalLetter++;
                }
                else if (inString[i].ToString() == letterUpper)
                {
                    totalUpper++;
                    totalLetter++;
                }
            }
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase " + letter + "'s found: " + totalLower);
            Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + totalUpper);
            Console.WriteLine("Total Number of " + letter + "'s found: " + totalLetter);
            Console.WriteLine();
        }

        //Creating TextStats function
        static void TextStats(string input)
        {
            var numChar = input.Length;
            var numCharSplit = input.Split(' ');
            var numWords = numCharSplit.Length;
            int numVowels = 0;
            int numConsonant = 0;
            int numSpecChar = 0;

            var biggestWord = "";
            var shortestWord = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            for (int i = 0; i < numCharSplit.Length; i++)
            {

                if (numCharSplit[i].Length > biggestWord.Length)
                {
                    biggestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < numCharSplit.Length; i++)
            {
                if (numCharSplit[i].Length < shortestWord.Length)
                {
                    shortestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input[i].ToString() == "u")
                {
                    numVowels = numVowels + 1;
                }
                else if (input[i].ToString() == "." || input[i].ToString() == "," || input[i].ToString() == "?" || input[i].ToString() == "!" || input[i].ToString() == "'")
                {
                    numSpecChar = numSpecChar + 1;
                }

                else if (input[i].ToString() != " ")
                {
                    numConsonant = numConsonant + 1;
                }
            }

            Console.WriteLine(input);
            Console.WriteLine("The number of characters is " + numChar);
            Console.WriteLine("The number of words is " + numWords);
            Console.WriteLine("The number of vowels is " + numVowels);
            Console.WriteLine("The number of consonants is " + numConsonant);
            Console.WriteLine("There are" + numSpecChar + "special characters");
            Console.WriteLine("Longest Word: " + biggestWord);
            Console.WriteLine("Shortest Word: " + shortestWord);
            Console.WriteLine();
        }
    }
}

        
        


            
        


       
			 
			
          



   


   
       
      




















