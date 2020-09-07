using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Toggle singlePlayerToggle;
    [SerializeField] Toggle twoPlayerToggle;
    [SerializeField] Slider goalLimitSlider;

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

        PlayerPrefsController.SetGoalLimit((int)goalLimitSlider.value);

        FindObjectOfType<SceneLoader>().LoadMainMenu();
    }
}
