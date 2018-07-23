using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string UserChoice, UserWordLower, UserWord, PigLatinWord;
            char FirstLetter;
            int FirstA, FirstE, FirstI, FirstO, FirstU, FirstVowel;
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            UserChoice = "y"; //User continue Loop
            while (UserChoice.ToLower() == "y")
            {
                Console.WriteLine("Enter the word you would like translated to Pig Latin.");
                UserWord = Console.ReadLine();
                UserWordLower = UserWord.ToLower(); //Converts input to lower case


                //process
                FirstLetter = UserWordLower[0];
                // extra 4: Don't translate words with numbers or symbols
                //NEEDS wider variety of symbols
                if (UserWordLower.Contains("@") || UserWordLower.Contains("1") || UserWordLower.Contains("2") || UserWordLower.Contains("3") || UserWordLower.Contains("4") || UserWordLower.Contains("5") || UserWordLower.Contains("6") || UserWordLower.Contains("7") || UserWordLower.Contains("8") || UserWordLower.Contains("9") || UserWordLower.Contains("0") || UserWordLower.Contains("!") || UserWordLower.Contains("#") || UserWordLower.Contains("$") || UserWordLower.Contains("%") || UserWordLower.Contains("^") || UserWordLower.Contains("&") || UserWordLower.Contains("*") || UserWordLower.Contains("(") || UserWordLower.Contains(")") || UserWordLower.Contains(":") || UserWordLower.Contains(";") || UserWordLower.Contains("{") || UserWordLower.Contains("}") || UserWordLower.Contains("[") || UserWordLower.Contains("]") || UserWordLower.Contains("<") || UserWordLower.Contains(">"))
                {
                    Console.WriteLine(UserWord);
                }
                else
                {
                    //determine if word starts with a vowel
                    if (FirstLetter == 'a' || FirstLetter == 'e' || FirstLetter == 'i' || FirstLetter == 'o' || FirstLetter == 'u')
                    {
                        //adds -way if word starts with vowel
                        Console.WriteLine($"{UserWordLower}way");
                    }
                    else //process for if word does not start with vowel
                    { 
                        //finds first instance of each vowel
                        FirstA = UserWordLower.IndexOf("a");
                        if (FirstA == -1)
                        {
                            FirstA = UserWordLower.Length-1;
                        }
                        FirstE = UserWordLower.IndexOf("e");
                        if (FirstE == -1)
                        {
                            FirstE = UserWordLower.Length - 1;
                        }
                        FirstI = UserWordLower.IndexOf("i");
                        if (FirstI == -1)
                        {
                            FirstI = UserWordLower.Length - 1;
                        }
                        FirstO = UserWordLower.IndexOf("o");
                        if (FirstO == -1)
                        {
                            FirstO = UserWordLower.Length - 1;
                        }
                        FirstU = UserWordLower.IndexOf("u");
                        if (FirstU == -1)
                        {
                            FirstU = UserWordLower.Length - 1;
                        }
                        //finds the lowest index of existing vowels within the word
                        FirstVowel = Math.Min(Math.Min(Math.Min(Math.Min(FirstA, FirstE),FirstI),FirstO),FirstU);

                        //Pig Latin Conversion
                        PigLatinWord = ($"{(UserWordLower.Substring(FirstVowel, (UserWordLower.Length - FirstVowel)))}{(UserWordLower.Substring(0,FirstVowel))}ay");

                        //Output
                        Console.WriteLine(PigLatinWord);
                    }
                }
                Console.WriteLine("Would you like to translate another word? \"(y/n)\"");
                UserChoice = Console.ReadLine();   
            }
            
        }
    }
}
