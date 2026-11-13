using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageExample : MonoBehaviour
{
    public delegate void OnDamageTaken(int damage);

    OnDamageTaken damageTaken;

    private void Start()
    {
        damageTaken += DisplayDamage;
        damageTaken += PlayDamageEffect;

        damageTaken?.Invoke(25);
    }

    void PlayDamageEffect(int damage)
    {
        Debug.Log("Playing damage effect for " + damage + " damage");
    }

    void DisplayDamage(int damage)
    {
        Debug.Log("Damage taken: " + damage);
    }
}
