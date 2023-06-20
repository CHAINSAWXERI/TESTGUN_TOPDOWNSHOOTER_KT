using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoxWithAmunition : MonoBehaviour
{
    public GUN Gun;
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
            Gun.TakeBoxAm();
            Destroy(gameObject);
        }
    }
}
