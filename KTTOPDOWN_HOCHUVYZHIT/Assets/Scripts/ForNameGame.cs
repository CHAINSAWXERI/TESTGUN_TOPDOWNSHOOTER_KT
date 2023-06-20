using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ForNameGame : MonoBehaviour
{
    private float maTime = 0.5f;
    float timeLeft;
    [SerializeField] private TMP_Text TEXT;
    void Start()
    {
        timeLeft = maTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            if (TEXT.alpha == 1)
            {
                TEXT.alpha = 0;
                timeLeft = maTime;
            }
            else
            {
                TEXT.alpha = 1;
                timeLeft = maTime;
            }
        }
    }
}
