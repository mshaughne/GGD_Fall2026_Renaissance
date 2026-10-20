using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ArraysDemo : MonoBehaviour
{
    //int[] array = { 3, 5, 9, 1, 2 };
    //string[] array = { "Hello", "world", "bingus" };

    [SerializeField]
    GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < objects.Length; i++)
        {
            Debug.Log("Object number " + i
                + " is " + objects[i].name);
        }*/

        foreach(var obj in objects)
        {
            //Debug.Log("Object is called " + obj.name);
            obj.transform.Translate(Vector3.up * 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
