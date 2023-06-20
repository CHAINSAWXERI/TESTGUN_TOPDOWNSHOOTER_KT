using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotGun : MonoBehaviour
{
    public float offset;
    public static int _amunitionGun = 1;
    [SerializeField] public GameObject _bullet;
    [SerializeField] public Transform _shotpoint;

    private float _timeShot;
    public float _starttumeShot;

    // Update is called once per frame
    void Update()
    {
        Vector2 _difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float _rotz = Mathf.Atan2(_difference.y, _difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, _rotz + offset);

        if (_timeShot <= 0)
        {
            if (Input.GetMouseButton(0) & (_amunitionGun > 0))
            {
                _amunitionGun--;
                Instantiate(_bullet, _shotpoint.position, transform.rotation);
                _timeShot = _starttumeShot;
            }
        }
        else
        {
            _timeShot -= Time.deltaTime;
        }
    }

    public void TakeBoxAm()
    {
        _amunitionGun = _amunitionGun + 3;
    }
}
