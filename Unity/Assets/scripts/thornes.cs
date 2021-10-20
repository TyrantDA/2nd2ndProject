using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thornes : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private string fire = "onfire";
    private Rigidbody2D mybody;
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("fire"))
        {
            anim.SetBool(fire, true);
            gameObject.tag = "fire";
            StartCoroutine(WaitTime());

        }

    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);



    }
}
