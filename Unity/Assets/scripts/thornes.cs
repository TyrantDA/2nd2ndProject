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
    public AudioClip clip;
    public float volume = 6;

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
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
            StartCoroutine(WaitTime2());
            gameObject.tag = "fire";
            StartCoroutine(WaitTime());

        }

    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);



    }
    private IEnumerator WaitTime2()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.transform.localScale += new Vector3(6, 6, 0);



    }
}
