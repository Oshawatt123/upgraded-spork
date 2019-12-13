using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UserTimer : MonoBehaviour
{
    private float startTime;
    private float duration = 180f;

    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime + duration <= Time.time)
        {
            SceneManager.LoadScene(2);
        }
        timeText.SetText((duration - (Time.time - startTime)).ToString());
    }
}