using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour     
{

    public InputField input;
    public Text userOutput;

    private int guessed_by_game;
    private int guessed_by_user;

    void Start()
    {
        guessed_by_game = Random.Range(1, 100);
        
    }

    public void GuessTheNumber()
    {
        guessed_by_user = int.Parse(input.text);

        if (guessed_by_user == guessed_by_game)
        {
            userOutput.text = "Congratulations ! You have guessed the right number.";
        }
        else if(guessed_by_game > guessed_by_user)
        {
            userOutput.text = "Oops ! You have guessed LESS than the Computer.";
        }
        else
        {
            userOutput.text = "Oops ! You have guessed MORE than the Computer.";
        }

        input.text = "";
    }

    
}
