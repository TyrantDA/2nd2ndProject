using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
