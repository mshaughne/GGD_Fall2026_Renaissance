using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalLerpDemo : MonoBehaviour
{

    float timeElapsed = 0f;
    public float timeDuration = 3f;

    Quaternion startRotation, targetRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.rotation;
        targetRotation = startRotation * Quaternion.Euler(45f, 45f, 45f);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeElapsed < timeDuration)
        {
            transform.rotation = Quaternion.Slerp(startRotation, targetRotation, timeElapsed / timeDuration);
            timeElapsed += Time.deltaTime;
            //Debug.Log(timeElapsed);
        }
    }
}
