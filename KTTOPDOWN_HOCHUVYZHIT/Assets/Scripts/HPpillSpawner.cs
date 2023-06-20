using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPpillSpawner : MonoBehaviour
{
    public float maTime;
    float timeLeft;
    private float maTime1 = 0.5f;
    float timeLeft1;
    [SerializeField] PillHealth Pill;
    [SerializeField] plr_control1 Player;
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
            Instantiate(Pill, _pos.position + new Vector3(0, 0), new Quaternion(0, 0, 0, 0)).Player = Player;
            timeLeft = maTime;
        }
    }
}
