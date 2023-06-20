using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillHealth : MonoBehaviour
{
    public plr_control1 Player;
    public int HP_up;
    public float LifeTime;
    float timeLeft;

    void Start()
    {
        timeLeft = LifeTime;
    }

    void Update()
    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.AddHealth(HP_up);
            Destroy(gameObject);
        }
    }
}
