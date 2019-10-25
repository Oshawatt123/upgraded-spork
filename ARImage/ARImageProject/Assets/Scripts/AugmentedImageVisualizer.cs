using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.UI;

public class AugmentedImageVisualizer : MonoBehaviour
{

    public AugmentedImage Image;
    public Image bing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            //no image and not tracking
            //return;
            transform.localScale = Vector3.zero;
            //bing.color = Color.red;
        }
        else
        {
            //image found and tracking
            //bing.color = Color.green;
            transform.localScale = new Vector3(Image.ExtentX, Image.ExtentZ, 1);
        }

    }
}