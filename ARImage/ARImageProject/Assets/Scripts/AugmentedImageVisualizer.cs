using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class AugmentedImageVisualizer : MonoBehaviour
{

    public AugmentedImage Image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            return;
        }

        transform.localScale = new Vector3(Image.ExtentX, Image.ExtentZ, 1);

    }
}