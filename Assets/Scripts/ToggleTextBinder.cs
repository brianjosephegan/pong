using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTextBinder : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] Slider slider;

    // Update is called once per frame
    private void Update()
    {
        text.text = slider.value.ToString();
    }
}
