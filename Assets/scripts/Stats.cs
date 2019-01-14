using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    [Header("Player stats: ")]
    public static int currentPlayer;
    public int CurrentPlayer;

    public static int numberOfPlayers;
    public int NumberOfPlayers;

    [Header("Number of players fields: ")]
    public static int fieldsToPlay;
    public int FieldsToPlay;

    [Header("1.Creating a table, 2.FIGHT, 3.END: ")]
    public static int stateOfTheGame;
    public int StateOfTheGame;

    void Start ()
    {
        currentPlayer = CurrentPlayer;
        numberOfPlayers = NumberOfPlayers;
        fieldsToPlay = FieldsToPlay;
        stateOfTheGame = StateOfTheGame;

    }
	
}
