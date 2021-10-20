using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybox : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Time.timeScale = 1;

        Destroy(transform.parent.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
