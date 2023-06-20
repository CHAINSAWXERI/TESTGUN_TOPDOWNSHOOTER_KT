using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    [SerializeField] public Transform _pos1;
    [SerializeField] public Transform _pos2;
    [SerializeField] public Transform _pos3;
    [SerializeField] public Transform _pos4;

    [SerializeField] BOSS _boss;
    BOSS _bossOnScene;

    [SerializeField] GameObject _Spawn1;
    [SerializeField] GameObject _Spawn2;
    [SerializeField] GameObject _Spawn3;
    [SerializeField] GameObject _Spawn4;
    [SerializeField] GameObject _Dark;

    void Start()
    {
        int x = Random.Range(1, 5);
        if (x == 1)
        {
            _bossOnScene = Instantiate(_boss, _pos1.position, transform.rotation);
        }
        if (x == 2)
        {
            _bossOnScene = Instantiate(_boss, _pos2.position, transform.rotation);
        }
        if (x == 3)
        {
            _bossOnScene = Instantiate(_boss, _pos3.position, transform.rotation);
        }
        if (x == 4)
        {
            _bossOnScene = Instantiate(_boss, _pos4.position, transform.rotation);
        }
    }

    void Update() 
    {
        if (_bossOnScene != null) 
        {
            if (_bossOnScene._health <= 0) 
            {
                _Spawn1.SetActive(true);
                _Spawn2.SetActive(true);
                _Spawn3.SetActive(true);
                _Spawn4.SetActive(true);
                Destroy(_Dark);
            }
        }
    }
}
