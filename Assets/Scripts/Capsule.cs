using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Capsule : MonoBehaviour
{
    // ENCAPSULATION
    protected string _name { get; set; }
    protected string _colorName { get; set; }
    protected Material _material { get; set; }
    protected string _materialName { get; set; }


    protected void Start()
    {
        OnStart();
    }

    protected abstract void OnStart();

    // DisplayText is an Example for ABSTRACTION
    public virtual void DisplayText()
    {
        MainManager.Instance.DisplayText("This is the shape class.");
    }
}