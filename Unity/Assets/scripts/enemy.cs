using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public bool Lightning = true;
    // Start is called before the first frame update
    void Start()
    {
        if (Godskripte.x.godbool1)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Lightning == false)
        {
            StartCoroutine(WaitTime());
        }



    }
    void OnMouseOver()

    {
        if (Lightning)
        { 
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
                Lightning = false;
            }
        }

    }

    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5f);
        Lightning = true;

    }
}
