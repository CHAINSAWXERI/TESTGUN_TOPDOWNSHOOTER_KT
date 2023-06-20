using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _timeAttack;
    public float _StartTimeAttack;
    private float _stopTime;
    public float _StartStopTime;
    public float _normalSpeed;
    private plr_control1 _Player;
    public ScoreScript SS;

    public int _health;
    public float _speed;
    public int _damage;

    private void Start()
    {
        _Player = FindObjectOfType<plr_control1>();
        
    }
    public void TakeDamageGun(int damage)
    {
        _stopTime = _StartStopTime;
        _health -= damage;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_stopTime <= 0)
        {
            _speed = _normalSpeed;
        }
        else
        {
            _speed = 0;
            _stopTime -= Time.deltaTime;
        }

        if (_health <= 0)
        {
            Debug.Log(SS);
            SS.AddPointScore(1);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, _Player.transform.position, _speed * Time.deltaTime);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_timeAttack <= 0)
            {
                OnEnemyAttack();
            }
            else
            {
                _timeAttack -= Time.deltaTime;
            }
        }
    }

    public void OnEnemyAttack()
    {
        _Player.ChargeHealth(_damage);
        _timeAttack = _StartTimeAttack;
    }
}
