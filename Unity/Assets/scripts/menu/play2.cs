using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class play2 : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        SceneManager.LoadScene("poem");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
