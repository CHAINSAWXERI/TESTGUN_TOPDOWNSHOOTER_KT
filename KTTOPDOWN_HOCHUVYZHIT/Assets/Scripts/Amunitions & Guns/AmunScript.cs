using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmunScript : MonoBehaviour
{
    [SerializeField] private TMP_Text TEXT;
    [SerializeField] private GUN Gun;

    void Update() 
    {
        TEXT.text = "AMUNITION: " + GUN._amunitionGun + " (Gun)";
    }
}
