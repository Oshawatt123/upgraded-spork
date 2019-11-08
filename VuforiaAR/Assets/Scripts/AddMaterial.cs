using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMaterial : MonoBehaviour
{

    public Material newMaterial;
    private Material[] mats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewMaterial(Transform objectToHighlight)
    {
        mats = objectToHighlight.GetComponent<Renderer>().materials;

        mats[0] = mats[0];
        mats[1] = newMaterial;
    }

    public void SetDefaultMaterial(Transform objectToUnHighlight)
    {
        mats = objectToUnHighlight.GetComponent<Renderer>().materials;

        mats[0] = mats[0];
    }
}