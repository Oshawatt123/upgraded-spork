using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class UpdateJournal : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour m_TrackableBehaviour;

    public CanvasGroup journalUpdate;

    // Start is called before the first frame update
    void Start()
    {
        m_TrackableBehaviour = GetComponent<TrackableBehaviour>();
        if(m_TrackableBehaviour)
        {
            m_TrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if(newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
        {
            journalUpdate.alpha = 1f;
        }
        else
        {
            journalUpdate.alpha = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
