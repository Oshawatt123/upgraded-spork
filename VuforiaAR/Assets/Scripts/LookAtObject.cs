using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{

    public AddMaterial addMaterialScript;
    public Camera lookCamera;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 middleOfScreen = new Vector3(Screen.width / 2, Screen.height / 2);
        Ray ray = lookCamera.ScreenPointToRay(middleOfScreen);

        if(Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            addMaterialScript.AddNewMaterial(objectHit);
        }
    }
}
