using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserTimer : MonoBehaviour
{
    private float startTime;
    private float duration = 300f;
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
    }
}