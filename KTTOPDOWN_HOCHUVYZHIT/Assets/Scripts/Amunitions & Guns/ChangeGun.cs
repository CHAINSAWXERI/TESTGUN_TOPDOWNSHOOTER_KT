using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ChangeGun : MonoBehaviour
{
    public GameObject[] Guns;
    private int _CurrentGun = 0;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            _CurrentGun++;
            if (_CurrentGun >= Guns.Length)
            {
                _CurrentGun = 0;
            }

            for (int i = 0; i < Guns.Length; i++)
            {
                if (i == _CurrentGun)
                {
                    Guns[i].SetActive(true);
                }
                else
                {
                    Guns[i].SetActive(false);
                }
            }
        }
    }
}