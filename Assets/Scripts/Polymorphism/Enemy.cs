using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Enemy health: " + health);
    }

    public virtual void Attack()
    {
        Debug.Log("The enemy used the default attack.");
    }
}

public class Goblin : Enemy
{
    public override void Attack()
    {
        Debug.Log("The goblin swings its sword.");
    }
}

public class Archer : Enemy
{
    public override void Attack()
    {
        Debug.Log("The archer shot an arrow.");
    }
}

public class Mage : Enemy
{

}