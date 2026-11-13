using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelPlayerHealth : MonoBehaviour
{
    public delegate void DamageDelegate(float damage);

    public DamageDelegate OnDamageTaken;

    public event DamageDelegate OnDamageTakenEvent;

    public float health = 100f;





    // public delegate void SimpleDelegate();
    // public delegate void Action();
    Action SimpleDelegate;

    // public delegate void Action(int blank, float blank1);
    Action<int, float> NotSoSimpleDelegate;

    // public delegate bool exampleFunc(int, float);
    Func<int, float, bool> exampleFunc;






    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10f);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        Debug.Log(health);

        OnDamageTaken?.Invoke(damage);
    }
}
