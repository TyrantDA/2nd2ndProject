using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptanim : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    public string pass1 = "pass1";
    public string pass2 = "pass2";
    public string pass3 = "pass3";
    public string pass4 = "pass4";
    public string pass5 = "pass5";
    public string pass6 = "pass6";
    public string pass7 = "pass7";
    public string pass8 = "pass8";
    public string pass9 = "pass9";
    public string pass10 = "pass10";
    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pass1"))
        {
            anim.SetBool(pass1, true);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);


        }
        if (collision.gameObject.CompareTag("pass2"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, true);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass3"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, true);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass4"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, true);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass5"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, true);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass6"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, true);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass7"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, true);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass8"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, true);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }
        if (collision.gameObject.CompareTag("pass9"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, true);
            anim.SetBool(pass10, false);

        }
        if (collision.gameObject.CompareTag("pass10"))
        {
            anim.SetBool(pass1, false);
            anim.SetBool(pass2, false);
            anim.SetBool(pass3, false);
            anim.SetBool(pass4, false);
            anim.SetBool(pass5, false);
            anim.SetBool(pass6, false);
            anim.SetBool(pass7, false);
            anim.SetBool(pass8, false);
            anim.SetBool(pass9, false);
            anim.SetBool(pass10, true);

        }

    }
}
