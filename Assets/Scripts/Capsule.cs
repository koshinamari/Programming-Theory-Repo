using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Capsule : MonoBehaviour
{
    
    public GameObject linkToObject;

    // ENCAPSULATION
    protected string _name { get; set; }
    protected string _colorName { get; set; }
    protected Color _materialColor { get; set; }
    protected string _materialName { get; set; }


    protected void Start()
    {
        OnStart();
    }

    protected abstract void OnStart();

    // DisplayText is an Example for ABSTRACTION
    public virtual void DisplayText()
    {
        StartCoroutine(ChangeSize());
    }

    public IEnumerator ChangeSize()
    {
        linkToObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(0.1f);
        linkToObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}