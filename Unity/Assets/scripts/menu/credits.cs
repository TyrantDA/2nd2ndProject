using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        SceneManager.LoadScene("credits");
    }

    // Update is called once per frame
    void Update()
    {

    }
}