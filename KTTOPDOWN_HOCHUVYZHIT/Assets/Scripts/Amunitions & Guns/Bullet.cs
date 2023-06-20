using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed;
    public float _lifetime;
    public float _distance;
    public int _damage;
    public LayerMask _whatIsSolid;
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
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, _distance, _whatIsSolid);
            Debug.DrawRay(transform.position, -transform.right * _distance);
            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    hitInfo.collider.GetComponent<Enemy>().TakeDamageGun(_damage);
                    Destroy(gameObject);
                }
                if (hitInfo.collider.CompareTag("Boss"))
                {
                    hitInfo.collider.GetComponent<BOSS>().TakeDamageGun(_damage);
                    Destroy(gameObject);
                }
                if (hitInfo.collider.CompareTag("Bwall"))
                {
                    hitInfo.collider.GetComponent<BrokeWall>().TakeDamageGun(_damage);
                    Destroy(gameObject);
                }
                if (hitInfo.collider.CompareTag("Wall"))
                {
                    Destroy(gameObject);
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
