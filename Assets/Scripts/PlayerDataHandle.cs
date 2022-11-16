using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Static member for save the current player data;
    public static PlayerDataHandle Instance { get; private set; } // other classes can only read but can`t set this variable - ENCAPSULATION

    public string PlayerName;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
