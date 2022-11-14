using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE from class Shape
public class BlueCapsule : Capsule
{
    // EXAMPLE for POLYMORPHYSM
    protected override void OnStart()
    {
        _name = "Cylinder";
        _colorName = "green";
        _material = transform.GetComponent<MeshRenderer>().material;
        _materialName = _material.name;
    }

    public override void DisplayText()
    {
        MainManager.Instance.DisplayText("This is a " + _name + " with color " + _colorName + " and material " + _materialName);
    }
}