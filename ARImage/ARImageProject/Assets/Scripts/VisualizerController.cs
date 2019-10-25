using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using System;
using UnityEngine.UI;

public class VisualizerController : MonoBehaviour
{
    [SerializeField] private AugmentedImageVisualizer augmentedImageVisualizer;

    private readonly Dictionary<int, AugmentedImageVisualizer> visualizers = new Dictionary<int, AugmentedImageVisualizer>();

    private readonly List<AugmentedImage> images = new List<AugmentedImage>();

    private void Update()
    {
        if(Session.Status != SessionStatus.Tracking)
        {
            return;
        }

        Session.GetTrackables(images, TrackableQueryFilter.Updated);
        VisualizeTrackables();
    }

    private void VisualizeTrackables()
    {
        foreach (var image in images)
        {
            var visualizer = GetVisualizer(image);

            // if tracking, but no visualizer
            if(image.TrackingState == TrackingState.Tracking && visualizer == null)
            {
                AddVisluazier(image);
            }
            // else if tracking has stopped and still has a visualizer
            else if (image.TrackingState == TrackingState.Stopped && visualizer != null)
            {
                RemoveVisualizer(image, visualizer);
            }
        }
    }



    public Image bing;
    private void AddVisluazier(AugmentedImage image)
    {
        // anchor is world position of our AR image so it can stay put in real world space when moving about
        var anchor = image.CreateAnchor(image.CenterPose);

        // create our visualized object
        var visualizer = Instantiate(augmentedImageVisualizer, anchor.transform);
        // set the image of the visualizer to the image we have tracked
        visualizer.Image = image;
        // add our visualizer to our list of visualizers
        visualizers.Add(image.DatabaseIndex, visualizer);



        bing.color = Color.green;
    }

    private void RemoveVisualizer(AugmentedImage image, AugmentedImageVisualizer visualizer)
    {
        visualizers.Remove(image.DatabaseIndex);
        Destroy(visualizer.gameObject);

        bing.color = Color.red;
    }

    private AugmentedImageVisualizer GetVisualizer(AugmentedImage image)
    {
        AugmentedImageVisualizer visualizer;
        visualizers.TryGetValue(image.DatabaseIndex, out visualizer);
        return visualizer;
    }
}
