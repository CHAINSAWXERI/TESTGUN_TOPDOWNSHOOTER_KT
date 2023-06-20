using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokeWall : MonoBehaviour
{
    public int _health;
    
    public void TakeDamageGun(int damage)
    {
        _health -= damage;
    }

    private void Update()
    {
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
