using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getSliderValue : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private InputField inputText;

    // Start is called before the first frame update
    void Start()
    {
        inputText = this.GetComponent<InputField>();
        inputText.text = ((int) slider.value).ToString();
    }

    public void getValue()
    {
        inputText.text = ((int)slider.value).ToString();
    }
}
