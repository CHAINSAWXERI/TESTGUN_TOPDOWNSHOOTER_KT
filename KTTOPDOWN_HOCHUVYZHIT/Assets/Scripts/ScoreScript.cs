using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TMP_Text TEXT;
    private int Score = 0;

    public void AddPointScore(int p) 
    {
        Score = Score + p;
        TEXT.text = "Score: " + Score;
    }
}
