using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class MenuOptions
    {
        int userChoice = 0;
        bool wrongInput = true;
        List<FoodItem> foodItems = new List<FoodItem>();

        public int PrintMenu ()
        {
            wrongInput = true;
            
            // Welcome messages and menu
            Console.WriteLine("What action would you like to take? (Enter the number): ");
            Console.WriteLine("1. Add Food Items");
            Console.WriteLine("2: Delete Food Items");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the Program");
            Console.WriteLine();
            
            // This loop continues asking the user for input until they give a correct number
            while (wrongInput)
            {
                try
                {
                    // Convert the user's choice to an integer
                    userChoice = Int32.Parse(Console.ReadLine());

                    // Checks if the number is between 1 and 4
                    if (userChoice >= 1 && userChoice <= 4)
                    {
                        // Exit the loop
                        wrongInput = false;
                    }
                    else
                    {
                        // Asks the user to enter a number in the correct range
                        Console.WriteLine("Input not in the valid range. Please input a number between 1 and 4!");
                    }

                }
                catch
                {
                    // Asks the user to enter a number
                    Console.WriteLine("Not a number, please input a valid number!");
                }
            }

            return userChoice;
        }

        public void AddFood()
        {
            string foodName = "";
            string foodCategory = "";
            int foodQuantity = 0;
            DateTime expDate = DateTime.Now;

            // Get the name of the food
            Console.WriteLine("What is the name of the food item?");
            foodName = Console.ReadLine();

            // Get the category of the food
            Console.WriteLine("What is the category of the food item?");
            foodCategory = Console.ReadLine();

            // Get the quantity of the food
            Console.WriteLine("What is the quantity of the food item?");
            wrongInput = true;

            // Check if the quantity given is a valid input
            while (wrongInput)
            {
                try
                {
                    // Convert the user's input to an integer
                    foodQuantity = Int32.Parse(Console.ReadLine());

                    // Checks if the number is not negative
                    if (foodQuantity >= 0)
                    {
                        // Exit the loop
                        wrongInput = false;
                    }
                    else
                    {
                        // Asks the user to enter a number in the correct range
                        Console.WriteLine("Quantity can't be negative. Please enter a valid number!");
                    }
                }
                catch
                {
                    // Asks the user to enter a number
                    Console.WriteLine("Not a number, please input a valid number!");
                }
            }

            // Get the expiration date of the food
            Console.WriteLine("What is the expiration date of the food item?");
            wrongInput = true;

            while (wrongInput)
            {
                try
                {
                    // Convert the user's input to a datetime
                    expDate = DateTime.Parse(Console.ReadLine());
                    wrongInput = false;
                }
                catch
                {
                    // Asks the user to enter a valid datetime
                    Console.WriteLine("Not a date, please input a valid date!");
                }
            }

            // Declare and instantiate a new food item using the FoodItem class
            FoodItem fi = new FoodItem(foodName, foodCategory, foodQuantity, expDate);
            foodItems.Add(fi);
            Console.WriteLine();
            Console.WriteLine("Food item successfully created. Please enter another action to take.");
        }

        public void DeleteFood()
        {
            int deleteItem = 0;
            wrongInput = true;
            
            // Check if there's food items in the list
            if (foodItems.Count > 0)
            {
                // Ask the user which food item to delete
                Console.WriteLine("Here are the current food items. Which one would you like to delete?");
                PrintFood();

                // Check if the food item number is valid
                while (wrongInput)
                {
                    try
                    {
                        // Convert the user's input to an integer
                        deleteItem = Int32.Parse(Console.ReadLine());

                        // Checks if the number is in range
                        if (deleteItem >= 1 && deleteItem <= foodItems.Count)
                        {
                            // Exit the loop
                            wrongInput = false;
                        }
                        else
                        {
                            // Asks the user to enter a number in the correct range
                            Console.WriteLine("Food item number doesn't exist. Please enter a valid number!");
                        }
                    }
                    catch
                    {
                        // Asks the user to enter a number
                        Console.WriteLine("Not a number, please input a valid number!");
                    }
                }

                // Delete the food item the user indicated
                foodItems.RemoveAt(deleteItem - 1);
                Console.WriteLine();
                Console.WriteLine("Food item successfully removed. Please enter another action to take.");
            } else
            {
                Console.WriteLine("There are no food items! Please add some through the main menu.");
            }
        }

        public void PrintFood()
        {            
            // Check if there's food items in the list
            if (foodItems.Count > 0)
            {
                // Print out each item in the food items list
                for (int i = 0; i < foodItems.Count; i++)
                {
                    Console.WriteLine($"Item {i + 1}: ");
                    Console.WriteLine($"Name: {foodItems[i].name}");
                    Console.WriteLine($"Category: {foodItems[i].category}");
                    Console.WriteLine($"Quantity: {foodItems[i].quantity}");
                    Console.WriteLine($"Expiration Date: {foodItems[i].date.ToString("MM/dd/yyyy")}");
                    Console.WriteLine();
                }
            } else
            {
                Console.WriteLine("There are no food items! Please add some through the main menu.");
            }
        }
    }
}
