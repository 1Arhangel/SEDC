using Model;
using Model.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do");
            Console.WriteLine("1. Input a word in the dictionary");
            Console.WriteLine("2. Remove a word from the dictionary");
            Console.WriteLine("3. Find a word in the dictionary");
            Console.WriteLine("4. Exit");
            string userInput = Console.ReadLine();
            int validUserInput;
            try
            {
                validUserInput = int.Parse(userInput);
               
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a valid request");
                validUserInput = int.Parse(Console.ReadLine());
            }
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.AddWord("lol", "lol");
            dictionary.AddWord("cool", "lol");
            dictionary.AddWord("cat", "cool");
            dictionary.AddWord("column", "animal");
            dictionary.AddWord("share", "value");
            dictionary.AddWord("class", "integer");

            switch (validUserInput)
            {
                case (int)MyDictionary.InputAWord:
                    Console.WriteLine("Please enter the word");
                    string word = Console.ReadLine();
                    try
                    {
                        dictionary.AddWord(word, word);
                        Console.WriteLine("The word was added to the dictionary");
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("The word already exists in the dictionary");
                    }
                    
                    
                    break;

                case (int)MyDictionary.RemoveAWord:
                    Console.WriteLine("Please enter the word you want removed");
                      string remove = Console.ReadLine();
                    if (!dictionary.ContainsKeyOrValue(remove))
                    {
                        Console.WriteLine("The word you want to remove doesnt exists in the dictionary");
                    }
                    else
                    {
                        dictionary.RemoveWord(remove);
                        Console.WriteLine("The word {0} was removed", remove);
                    }
                    

                    break;

                case (int)MyDictionary.Exists:
                    Console.WriteLine("Enter the word you want to find");
                    string find = Console.ReadLine();
                    dictionary.ContainsKeyOrValue(find);
                    Console.WriteLine(dictionary.ContainsKeyOrValue(find));

                    break;

                case (int)MyDictionary.Exit:
                    Console.WriteLine("It is now safe to exit. Press Enter");
                    break;
                default:
                    break;
            }

            
            

           
            
            


            Console.ReadLine();
        }
    }
}
