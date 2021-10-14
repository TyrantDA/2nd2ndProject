using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godbutton3 : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private string buttonpushed = "pushed";
    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {

    }
    private void OnMouseDown()
    {
        Godskripte.x.godbool1 = false;
        Godskripte.x.godbool2 = false;
        Godskripte.x.godbool3 = true;
        Godskripte.x.godbool4 = false;
        Godskripte.x.godbool5 = false;
    }
    void Pushthebutton()
    {
        if (Godskripte.x.godbool3)
        {
            anim.SetBool(buttonpushed, true);
        }
        if (!Godskripte.x.godbool3)
        {
            anim.SetBool(buttonpushed, false);
        }
    }
    void Update()
    {
        Pushthebutton();
    }
}
