using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float maTime;
    float timeLeft;
    private float maTime1 = 0.5f;
    float timeLeft1;
    [SerializeField] Enemy _enemy;
    [SerializeField] ScoreScript _SS;
    [SerializeField] Transform _pos;

    void Start()
    {
        timeLeft = maTime;
        timeLeft1 = maTime1;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            for (int i = 0; i < 5; i++) 
            {
                Instantiate(_enemy, _pos.position + new Vector3(Random.Range(-2f,2f), Random.Range(-2f,2f)), new Quaternion(0,0,0,0)).SS=_SS;
            }
            timeLeft = maTime;
        }
    }
}
