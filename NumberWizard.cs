using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to number wizard!");
        Debug.Log("Please pick a number and don't tell me what it is...");
        Debug.Log("Highest number your can pick is " +max);
        Debug.Log("Lowest number you can pick is " +min);
        Debug.Log("Tell me if your number is higher or lower than: "+guess);
        Debug.Log("Push up= Higher, Push down= Lower, Push Enter= Correct! ");
        max = max + 1;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("I see... Your number is higher than my guess...");
            min = guess;
            NextGuess();
            
        }

        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("I see... Your number is lower than my guess...");
            max = guess;
            NextGuess();
        }

        else if(Input.GetKeyDown(KeyCode.Return)) 
        {
            Debug.Log("Gotcha!I am a genious!");
            Debug.Log("Wanna play again? If yes please push enter!");
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartGame();
            }
        }
            
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher than or lower than..." + guess);
    }
}
