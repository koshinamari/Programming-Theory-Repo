using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// INHERITANCE from class Shape
public class WhiteCapsule : Capsule
{
    

    // EXAMPLE for POLYMORPHYSM
    protected override void OnStart()
    {
        _name = "Capsule 1";
        _colorName = "white";
        _materialColor = transform.GetComponent<MeshRenderer>().sharedMaterial.color;
     
    }

    public override void DisplayText()
    {
        // The base label tells the script to run the original method in addition to the new code in this override method.
        base.DisplayText();

        MainManager.Instance.DisplayText("This is a " + _name + " with color " + _colorName);
        MainManager.Instance.textToDisplay.color = _materialColor;
    }
}
