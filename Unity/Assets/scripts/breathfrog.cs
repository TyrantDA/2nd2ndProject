using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathfrog : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    public string breathing = "isbreath";
    public bool going = false;
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
        if (!going)
        {
            going = true;
            StartCoroutine(breath());

        }

    }
    private IEnumerator breath()
    {
        anim.SetBool(breathing, true);
        yield return new WaitForSeconds(1f);
        anim.SetBool(breathing, false);
        yield return new WaitForSeconds(7f);
        going = false;



    }
}
