using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerFire : MonoBehaviour
{
    public float damage;

    public bool hasCollide = false;
    // Start is called before the first frame update

    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Enemy" && !hasCollide)
        {
            // Monster_First m = collision.gameObject.GetComponent<Monster_First>();
            IEnemyDamage m = other.GetComponent<IEnemyDamage>();
                // m.getDamage(damage);
                if (m == null) return;
                m.hitTheEnemy(damage);
                hasCollide = true;
        }
    }
    
}
