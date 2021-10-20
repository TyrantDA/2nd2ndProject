using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
