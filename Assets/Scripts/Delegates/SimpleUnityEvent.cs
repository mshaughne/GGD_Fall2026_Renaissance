using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleUnityEvent : MonoBehaviour
{
    public UnityEvent OnButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        //OnButtonPressed.AddListener();
        //OnButtonPressed.RemoveListener();
        //OnButtonPressed.RemoveAllListeners();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OnButtonPressed?.Invoke();
        }
    }
}
