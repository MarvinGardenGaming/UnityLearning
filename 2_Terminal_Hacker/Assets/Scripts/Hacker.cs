using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;
    
    // Creating enum
    enum Screen { MainMenu, Password, Win };

    // Initialize Screen as MainMenu
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for Starbuck wifi");
        Terminal.WriteLine("Press 2 for College wifi");
        Terminal.WriteLine("Press 3 for Bank wifi");
        Terminal.WriteLine("Type Menu to go back to the menu");
    }

    void OnUserInput(string input)
    {
        if (input == "Menu")
        {
            ShowMainMenu();
        } else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Please select a menu item Mr. Bond");
        } else
        {
            Terminal.WriteLine("Please enter a valid option");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        if (level == 1)
        {
            Terminal.WriteLine("You chose to hack into starbuck wifi");
        } else if (level == 2)
        {
            Terminal.WriteLine("You chose to hack into college wifi");
        } else if (level == 3)
        {
            Terminal.WriteLine("You chose to hack into bank wifi");
        }
       
    }
}
