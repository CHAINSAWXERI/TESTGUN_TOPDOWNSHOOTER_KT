using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plr_control1 : MonoBehaviour
{
    private Vector2 _direction;
    private Rigidbody2D _rb;

    public float _speed;
    public int _health;
    public int SceneAfterDeath;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.y = Input.GetAxisRaw("Vertical");
        if (_health <= 0)
        {
            SceneManager.LoadScene(SceneAfterDeath);
        }
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _direction * _speed * Time.fixedDeltaTime);
    }

    public void ChargeHealth(int healthvalue)
    {
        _health -= healthvalue;
    }

    public void AddHealth(int healthvalue)
    {
        _health += healthvalue;
        if (_health > 50) 
        {
            _health = 50;
        }
    }
}
