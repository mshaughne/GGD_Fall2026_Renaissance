using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    public delegate void SimpleDelegate();

    SimpleDelegate exampleDelegate;

    private void Start()
    {
        exampleDelegate = HelloWorld;
        exampleDelegate();
        exampleDelegate = GoodbyeWorld;
        exampleDelegate();

        exampleDelegate = HelloWorld;
        exampleDelegate += GoodbyeWorld;

        exampleDelegate();
    }

    void HelloWorld()
    {
        Debug.Log("Hello world");
    }

    void GoodbyeWorld()
    {
        Debug.Log("Goodbye world");
    }
}
