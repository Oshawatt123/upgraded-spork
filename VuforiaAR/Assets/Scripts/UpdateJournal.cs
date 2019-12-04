using UnityEngine;
using Vuforia;

public class UpdateJournal : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour m_TrackableBehaviour;

    public CanvasGroup journalUpdate;

    //public Text debugText;

    public Journal journal;

    // Start is called before the first frame update
    void Start()
    {
        m_TrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (m_TrackableBehaviour)
        {
            m_TrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        // this is due to the canvasGroup being destroyed before this does, and on destroy the state changes
        // so we are checking this to ensure no errors in the final product
        if (journalUpdate)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED)
            {
                journalUpdate.alpha = 1f;
                switch (m_TrackableBehaviour.name)
                {
                    case "Gun":
                        journal.ShowEntry(m_TrackableBehaviour.name);
                        break;
                    case "Body":
                        journal.ShowEntry(m_TrackableBehaviour.name);
                        break;
                    default:
                        //debugText.text = "This object has not been programmed";
                        break;
                }
            }
            else
            {
                journalUpdate.alpha = 0f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
