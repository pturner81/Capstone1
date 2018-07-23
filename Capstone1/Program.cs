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
            //Convert user input word to PigLatin

            //input
            string UserChoice, UserWordLower, UserWord, PigLatinWord;
            char FirstLetter;
            int FirstA, FirstE, FirstI, FirstO, FirstU, FirstVowel, LastLetter;
            Console.WriteLine("Welcome to the Pig Latin Translator!");

            UserChoice = "y"; //User continue Loop
            while (UserChoice.ToLower() == "y")
            {
                Console.WriteLine("Enter the word you would like translated to Pig Latin.");
                UserWord = Console.ReadLine();

                //extra #5: Check that user has actually entered text before translating
                while (UserWord == "")
                {
                    Console.WriteLine("Please enter a word");
                    UserWord = Console.ReadLine();
                }

                UserWordLower = UserWord.ToLower(); //Converts input to lower case


                //process
                FirstLetter = UserWordLower[0];
                //extra #4: Don't translate words with numbers or symbols & Translate contractions (partial) Needs wider variety of symbols
                //extra #3: Translate contractions
                if (UserWordLower.Contains("@") || UserWordLower.Contains("1") || UserWordLower.Contains("2") || UserWordLower.Contains("3") || UserWordLower.Contains("4") || UserWordLower.Contains("5") || UserWordLower.Contains("6") || UserWordLower.Contains("7") || UserWordLower.Contains("8") || UserWordLower.Contains("9") || UserWordLower.Contains("0") || UserWordLower.Contains("#") || UserWordLower.Contains("$") || UserWordLower.Contains("%") || UserWordLower.Contains("^") || UserWordLower.Contains("&") || UserWordLower.Contains("*") || UserWordLower.Contains("(") || UserWordLower.Contains(")") || UserWordLower.Contains(":") || UserWordLower.Contains(";") || UserWordLower.Contains("{") || UserWordLower.Contains("}") || UserWordLower.Contains("[") || UserWordLower.Contains("]") || UserWordLower.Contains("<") || UserWordLower.Contains(">"))
                {
                    Console.WriteLine(UserWord);
                }
                else
                {
                    //determine if word starts with a vowel
                    if (FirstLetter == 'a' || FirstLetter == 'e' || FirstLetter == 'i' || FirstLetter == 'o' || FirstLetter == 'u')
                    {
                        //adds -way if word starts with vowel
                        LastLetter = UserWordLower.Length - 1;
                        //extra #2: allows punctuation in the input string for words not beginning with a vowel
                        if (UserWordLower[LastLetter] == '.' || UserWordLower[LastLetter] == '?' || UserWordLower[LastLetter] == '!')
                        {
                            Console.WriteLine($"{UserWord.Substring(0,LastLetter)}way{UserWord.Substring(LastLetter)}");
                        }
                        else
                        {
                            Console.WriteLine($"{UserWord}way"); //extra #2:(partial) Keeps capitalization of first letter (for words staring with a vowel)
                        }
                    }
                    else //process for if word does not start with vowel
                    {
                        //finds first instance of each vowel
                        FirstA = UserWordLower.IndexOf("a");
                        if (FirstA == -1)
                        {
                            FirstA = UserWordLower.Length - 1;
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
                        FirstVowel = Math.Min(Math.Min(Math.Min(Math.Min(FirstA, FirstE), FirstI), FirstO), FirstU);

                        //Pig Latin Conversion
                        LastLetter = UserWordLower.Length - 1;
                        //extra #2: allows punctuation in the input string for words not beginning with a vowel
                        if (UserWordLower[LastLetter] == '.' || UserWordLower[LastLetter] == '?' || UserWordLower[LastLetter] == '!')
                        {
                            PigLatinWord = ($"{(UserWordLower.Substring(FirstVowel, (UserWordLower.Length - (FirstVowel+1))))}{(UserWordLower.Substring(0, FirstVowel))}ay{UserWordLower[LastLetter]}");
                        }
                        else
                        {
                            PigLatinWord = ($"{(UserWordLower.Substring(FirstVowel, (UserWordLower.Length - FirstVowel)))}{(UserWordLower.Substring(0, FirstVowel))}ay");
                        }
                        
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
