using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsController : MonoBehaviour
{
    const string NUMBER_OF_PLAYERS_KEY = "number of players";

    public static void SetNumberOfPlayers(int numberOfPlayers)
    {
        PlayerPrefs.SetInt(NUMBER_OF_PLAYERS_KEY, numberOfPlayers);
    }

    public static int GetNumberOfPlayer()
    {
        return PlayerPrefs.GetInt(NUMBER_OF_PLAYERS_KEY);
    }
}
