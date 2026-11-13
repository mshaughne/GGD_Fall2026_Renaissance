using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelDamageUI : MonoBehaviour
{
    public DelPlayerHealth player;

    private void OnEnable()
    {
        player.OnDamageTaken += DisplayDamage;
    }

    private void OnDisable()
    {
        player.OnDamageTaken -= DisplayDamage;
    }

    void DisplayDamage(float damage)
    {
        Debug.Log("UI: Player took " + damage + " damage");
    }
}
