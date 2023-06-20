using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    public int _health;
    [SerializeField] GameObject _exit;
    [SerializeField] public Transform _exitpoint;
    [SerializeField] EnemySpawn _enemyspawn;
    

    public void TakeDamageGun(int damage)
    {
        _health -= damage;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_health <= 0)
        {
            Destroy(gameObject);
            Instantiate(_exit, _exitpoint.position, transform.rotation);

        }
    }

}
