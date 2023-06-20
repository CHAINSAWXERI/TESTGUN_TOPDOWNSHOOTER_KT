using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthScript : MonoBehaviour
{
    [SerializeField] private TMP_Text TEXT;
    [SerializeField] private plr_control1 HP;

    void Update() 
    {
        TEXT.text = "HP: " + HP._health + "/50";
    }
}
