using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Toggle singlePlayerToggle;
    [SerializeField] Toggle twoPlayerToggle;
    [SerializeField] Slider goalLimitSlider;
    [SerializeField] Slider soundVolumeSlider;

    [SerializeField] int defaultGoalLimit = 3;
    [SerializeField] float defaultSoundVolume = 80f;

    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefsController.GetNumberOfPlayer() == 1)
        {
            singlePlayerToggle.isOn = true;
        }
        else
        {
            twoPlayerToggle.isOn = true;
        }

        goalLimitSlider.value = PlayerPrefsController.GetGoalLimit();
        soundVolumeSlider.value = PlayerPrefsController.GetSoundVolume();
    }

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
        PlayerPrefsController.SetSoundVolume(soundVolumeSlider.value);

        FindObjectOfType<SceneLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        singlePlayerToggle.isOn = true;
        goalLimitSlider.value = defaultGoalLimit;
        soundVolumeSlider.value = defaultSoundVolume;
    }
}
