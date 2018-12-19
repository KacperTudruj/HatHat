using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    [Header("Player stats: ")]
    public static int currentPlayer;
    public int CurrentPlayer;

    public static int numberOfPlayer;
    public int NumberOfPlayer;

    void Start ()
    {
        currentPlayer = CurrentPlayer;
        numberOfPlayer = NumberOfPlayer;
	}
	
}
