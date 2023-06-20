using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmunScriptDROB : MonoBehaviour
{
    [SerializeField] private TMP_Text TEXT;
    [SerializeField] private DROB Gun;

    void Update()
    {
        TEXT.text = DROB._amunitionGun + " (Shotgun)";
    }
}
