using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class exitcredit : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        SceneManager.LoadScene("startmenu");
    }

    // Update is called once per frame
}
