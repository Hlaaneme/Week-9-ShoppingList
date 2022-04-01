using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\ShoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add groceries to your shopping list? Y/N: ");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());


                if(userInput == 'y')
                {
                    Console.WriteLine("You may add groceries to your shopping list:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);

                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

                
            }

            Console.Clear();

            foreach (string Item in myShoppingList)
            {
                Console.WriteLine($"Your shopping list: {Item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
