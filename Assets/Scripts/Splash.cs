using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadUI", 2);
    }

    // Loading UI 
    private void LoadUI()
    {
        SceneManager.LoadScene(1);
    }
}
