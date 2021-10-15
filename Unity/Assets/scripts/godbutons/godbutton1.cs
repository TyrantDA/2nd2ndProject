using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godbutton1 : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    [SerializeField]
    private string buttonpushed = "pushed";
    private string buttoncool = "Cooldwon";

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
        Godskripte.x.godbool1 = true;
        Godskripte.x.godbool2 = false;
        Godskripte.x.godbool3 = false;
        Godskripte.x.godbool4 = false;
        Godskripte.x.godbool5 = false;
    }

    void Pushthebutton()
    {
        if (Godskripte.x.godbool1)
        {
            anim.SetBool(buttonpushed, true);
        }
        if (!Godskripte.x.godbool1)
        {
            anim.SetBool(buttonpushed, false);
        }
    }
    void cooldownbutton()
    {
        if (Godskripte.x.Lightningcooldown)
        {
            anim.SetBool(buttoncool, false);
        }
        if (!Godskripte.x.Lightningcooldown)
        {
            anim.SetBool(buttoncool, true);
        }

    }

    void Update()
    {
         Pushthebutton();
         cooldownbutton();
    }
}
