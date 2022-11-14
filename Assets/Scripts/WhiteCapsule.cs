using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE from class Shape
public class WhiteCapsule : Capsule
{
    // EXAMPLE for POLYMORPHYSM
    protected override void OnStart()
    {
        _name = "Capsule";
        _colorName = "yellow";
        _material = transform.GetComponent<MeshRenderer>().material;
        _materialName = _material.name;
    }

    public override void DisplayText()
    {
        MainManager.Instance.DisplayText("This is a " + _name + " with color " + _colorName + " and material " + _materialName);
    }

}
