using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OSGAmunScript : MonoBehaviour
{
    [SerializeField] private TMP_Text TEXT;
    [SerializeField] private OneShotGun Gun;

    void Update()
    {
        TEXT.text = OneShotGun._amunitionGun + " (OSG)";
    }
}
