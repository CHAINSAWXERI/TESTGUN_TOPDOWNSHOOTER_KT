using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmBoDROBspawner : MonoBehaviour
{
    public float maTime;
    float timeLeft;
    private float maTime1 = 0.5f;
    float timeLeft1;
    [SerializeField] BoxWithAmDROB Box;
    [SerializeField] DROB Gun;
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
            Instantiate(Box, _pos.position + new Vector3(0, 0), new Quaternion(0, 0, 0, 0)).Gun = Gun;
            timeLeft = maTime;
        }
    }
}
