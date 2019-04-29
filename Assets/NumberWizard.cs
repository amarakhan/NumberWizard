using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to the number wizard!");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max += 1;
        //Debug.Log("");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            GuessAgain();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            GuessAgain();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Wow, you guessed right!");
        }
    }

    void GuessAgain()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess + "?");
    }
}
