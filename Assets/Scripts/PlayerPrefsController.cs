using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsController : MonoBehaviour
{
    const string NUMBER_OF_PLAYERS_KEY = "number of players";
    const string GOAL_LIMIT_KEY = "goal limit";
    const string SOUND_VOLUME_KEY = "sound volume";

    public const int DEFAULT_NUMBER_OF_PLAYERS = 1;
    public const int DEFAULT_GOAL_LIMIT = 3;
    public const float DEFAULT_SOUND_VOLUME = 80f;

    public static bool HasNumberOfPlayers()
    {
        return PlayerPrefs.HasKey(NUMBER_OF_PLAYERS_KEY);
    }

    public static void SetNumberOfPlayers(int numberOfPlayers)
    {
        PlayerPrefs.SetInt(NUMBER_OF_PLAYERS_KEY, numberOfPlayers);
    }

    public static int GetNumberOfPlayer()
    {
        if (HasNumberOfPlayers())
        {
            return PlayerPrefs.GetInt(NUMBER_OF_PLAYERS_KEY);
        }
        else
        {
            return DEFAULT_NUMBER_OF_PLAYERS;
        }
    }

    public static bool HasGoalLimit()
    {
        return PlayerPrefs.HasKey(GOAL_LIMIT_KEY);
    }

    public static void SetGoalLimit(int goalLimit)
    {
        PlayerPrefs.SetInt(GOAL_LIMIT_KEY, goalLimit);
    }

    public static int GetGoalLimit()
    {
        if (HasGoalLimit())
        {
            return PlayerPrefs.GetInt(GOAL_LIMIT_KEY);
        }
        else
        {
            return DEFAULT_GOAL_LIMIT;
        }
    }

    public static bool HasSoundVolume()
    {
        return PlayerPrefs.HasKey(SOUND_VOLUME_KEY);
    }

    public static void SetSoundVolume(float soundVolume)
    {
        PlayerPrefs.SetFloat(SOUND_VOLUME_KEY, soundVolume);
    }

    public static float GetSoundVolume()
    {
        if (HasSoundVolume())
        {
            return PlayerPrefs.GetFloat(SOUND_VOLUME_KEY);
        }
        else
        {
            return DEFAULT_SOUND_VOLUME;
        }
    }
}
