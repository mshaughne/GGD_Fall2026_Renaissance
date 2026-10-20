using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*Enemy enemy1 = new Goblin();
        Enemy enemy2 = new Archer();
        Enemy enemy3 = new Mage();

        enemy1.Attack();
        enemy2.Attack();
        enemy3.Attack();*/

        Enemy[] enemies = {
            new Goblin(),
            new Archer(),
            new Mage()
        };

        foreach(Enemy enemy in enemies)
        {
            enemy.Attack();
        }
    }
}
