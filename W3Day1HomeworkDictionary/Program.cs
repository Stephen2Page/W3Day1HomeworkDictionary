using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Day1HomeworkDictionary
{
    class Program
    {
        //Create a the following Dictionary:
        //  Dictionary<string, int> animals = new Dictionary<string, int>();
        //  Add 6 animals in the following format
        //  animals.Add("Bear", 4);
        //  animals.Add("Squid", 10);
        //  animals.Add("Bird", 2);

        //Run queries against the dictionary in the following format.
        //  Test different animals.
        //  Try animals that aren’t in the dictionary.

        //if (dictionary.ContainsKey("Bear"))
        //{
        //	int value = dictionary["Bear"];
        //  Console.WriteLine(“Bear has ” + value + ” legs.”);
        //}

        //  How can we make the previous queries more efficient to use?

        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("lion", 4);
            animals.Add("centiped", 100);
            animals.Add("amobea", 0);
            animals.Add("eagle", 2);
            animals.Add("spider", 8);


            while (true)
            {
                Console.WriteLine("Enter an animal name");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (animals.ContainsKey(input))
                {
                    int value = animals[input];
                    Console.WriteLine("{0} {1} has {2} legs.", AOrAn(input), input, value);
                }
                else
                {
                    Console.WriteLine("We have no record for {0} {1}.", AOrAn(input).ToLower(), input );
                }

            }
        }
        public static string AOrAn(string input)        //Checking for which article to use
        {
            if (IsFirstLetterVowel(input))
            {

                return "An";
            }
            else
            {
                return "A";
            }
        }

        public static bool IsFirstLetterVowel(string word)
        {
            // Obtained from StackOverflow
            char firstLetter = word[0];
            bool isVowel = "aeiouAEIOU".IndexOf(firstLetter) >= 0; //checks if first letter of word is no in this list
            return isVowel;
           
        }
    }
}
