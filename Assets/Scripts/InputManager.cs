using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InputManager : MonoBehaviour
{

    public Transform pointer;
    void LateUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);


        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            pointer.position = hit.point;

            if (Input.GetMouseButtonDown(0))
        {
           
                Transform hitTransform = hit.transform;
                switch (hit.transform.name)
                {
                    case "White":
                        hitTransform.GetComponent<Capsule>().linkToObject = hit.transform.gameObject;
                        hitTransform.GetComponent<WhiteCapsule>().DisplayText();
                        

                        break;

                    case "Green":
                        hitTransform.GetComponent<Capsule>().linkToObject = hit.transform.gameObject;
                        hitTransform.GetComponent<GreenCapsule>().DisplayText();
                        

                        break;

                    case "Blue":
                        hitTransform.GetComponent<Capsule>().linkToObject = hit.transform.gameObject;
                        hitTransform.GetComponent<BlueCapsule>().DisplayText();
                        

                        break;

                }
            }
        }

        


    }
        
}