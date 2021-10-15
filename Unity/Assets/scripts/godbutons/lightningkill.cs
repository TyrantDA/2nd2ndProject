using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightningkill : MonoBehaviour
{
    private Rigidbody2D mybody;
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("lightning"))
        {
            Destroy(gameObject);
        }

    }
}
