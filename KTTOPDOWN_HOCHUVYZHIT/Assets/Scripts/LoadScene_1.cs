using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene_1 : MonoBehaviour
{
    public int SceneIndex;
    public void loadscene()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
