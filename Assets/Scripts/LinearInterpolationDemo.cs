using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolationDemo : MonoBehaviour
{
    public float start = 0, stop = 100;
    float t = 0.5f;
    float timeElapsed = 0f;
    public float timeDuration = 3f;

    private void Start()
    {
        //float x = Mathf.Lerp(start, stop, t);
        //Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeElapsed < timeDuration)
        {
            float value = Mathf.Lerp
                (start, stop, timeElapsed/timeDuration);
            transform.position = new Vector3(value, value, 0);

            timeElapsed += Time.deltaTime;
            //timeElapsed = timeElapsed + Time.deltaTime;
        }
    }
}
