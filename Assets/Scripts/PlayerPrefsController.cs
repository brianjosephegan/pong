using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsController : MonoBehaviour
{
    const string NUMBER_OF_PLAYERS_KEY = "number of players";
    const string GOAL_LIMIT_KEY = "goal limit";

    public static void SetNumberOfPlayers(int numberOfPlayers)
    {
        PlayerPrefs.SetInt(NUMBER_OF_PLAYERS_KEY, numberOfPlayers);
    }

    public static int GetNumberOfPlayer()
    {
        return PlayerPrefs.GetInt(NUMBER_OF_PLAYERS_KEY);
    }

    public static void SetGoalLimit(int goalLimit)
    {
        PlayerPrefs.SetInt(GOAL_LIMIT_KEY, goalLimit);
    }

    public static int GetGoalLimit()
    {
        return PlayerPrefs.GetInt(GOAL_LIMIT_KEY);
    }
}
