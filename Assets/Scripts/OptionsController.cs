using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Toggle singlePlayerToggle;
    [SerializeField] Toggle twoPlayerToggle;

    public void SaveAndExit()
    {
        if (singlePlayerToggle.isOn)
        {
            PlayerPrefsController.SetNumberOfPlayers(1);
        }
        else if (twoPlayerToggle.isOn)
        {
            PlayerPrefsController.SetNumberOfPlayers(2);
        }

        FindObjectOfType<SceneLoader>().LoadMainMenu();
    }
}
