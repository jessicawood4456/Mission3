using System.Runtime.InteropServices;
using Mission3;

int userChoice = 0;
bool wrongInput = true;
bool noExit = true;
List<FoodItem> foodItems = new List<FoodItem>();

// Display a welcome message and the menu
Console.WriteLine("Hello! Welcome to the Food Bank Inventory System!");
MenuOptions dm = new MenuOptions();
userChoice = dm.PrintMenu();

// As long as the user hasn't exited the program, keep checking the user choice
while (noExit)
{
    if (userChoice == 1)
    {
        // Add a new food item
        dm.AddFood();

        // Reset user choice so they can choose another menu option
        userChoice = 0;
        userChoice = dm.PrintMenu();

    } else if (userChoice == 2)
    {
        // Delete a food item
        dm.DeleteFood();

        // Reset user choice so they can choose another menu option
        userChoice = 0;
        userChoice = dm.PrintMenu();

    }
    else if (userChoice == 3)
    {        
        // Print the food items
        dm.PrintFood();

        // Reset user choice so they can choose another menu option
        userChoice = 0;
        userChoice = dm.PrintMenu();

    }
    else if (userChoice == 4)
    {
        // Exit the program
        Console.WriteLine("Thank you for using the Food Bank Inventory System. Goodbye!");
        noExit = false;
    }
}


