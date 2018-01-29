using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;

            Console.WriteLine("Welcome to the English to pig latin translator");

            while (run == true)
            { 
                Console.Write("Please enter a word to translate:  ");
                string word = Console.ReadLine();

                char[] letters = word.ToCharArray();
                
                char firstLetter = letters[0];

                if (IsVowel(firstLetter)) 
                {
                    word = word + "way";
                    Console.WriteLine(word);
                }
                else
                {
                    pigword(word);
                }
                
                run = Continue();
            }

        }

        private static string pigword(string word)
        {
            while (word.IndexOf('a') != 0 && word.IndexOf('e') != 0 && word.IndexOf('i') != 0 && word.IndexOf('o') != 0 && word.IndexOf('u') != 0)
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1);
                word = restOfWord + firstLetter;
            }

            Console.WriteLine(word + "ay");
            return word;
        }

        static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'}; 

            foreach (char vowel in vowels)
            {
                if (c == vowel)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool Continue()
        {
            Console.WriteLine("Continue? Y/N");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Unknown input");
                run = Continue();
            }

            return run;
        }


    }    
}
