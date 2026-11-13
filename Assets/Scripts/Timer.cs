using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI m_TextMeshProUGUI;

    float timeRemaining = 100f;
    float minutes;
    float seconds;

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
            Debug.Log(minutes + ":" + seconds + " remaining");
            m_TextMeshProUGUI.text = minutes + ":" + seconds;
        }
    }

    void DisplayTime(float timeRemaining)
    {
        float minutes = Mathf.FloorToInt(timeRemaining / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
    }
}
