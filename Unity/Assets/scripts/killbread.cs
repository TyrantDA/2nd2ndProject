using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbread : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Godskripte.x.isbread = false;
            Destroy(gameObject);
        }

    }
}
