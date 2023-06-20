using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotBullet : MonoBehaviour
{
    public float _speed;
    public float _lifetime;
    public float _distance;
    public int _damage;
    private float _maTime = 3f;
    private float _timeLeft;

    private void Start()
    {
        _timeLeft = _maTime;
    }
    private void Update()
    {
        if (_timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, _distance);
            Debug.DrawRay(transform.position, -transform.right * _distance);
            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    hitInfo.collider.GetComponent<Enemy>().TakeDamageGun(_damage);
                }
            }
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
