using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    [SerializeField] private Text textToDisplay;


    private void Awake()
    {
        Instance = this;
        textToDisplay.text = "Hello " + PlayerDataHandle.Instance.PlayerName + "! Click on any capsule:)";
    }

    // Display Text on Screen
    public void DisplayText(string text)
    {
        textToDisplay.text = text;
    }

}
