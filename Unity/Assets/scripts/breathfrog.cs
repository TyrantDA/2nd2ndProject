using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathfrog : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    public string breathing = "isbreath";
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
        StartCoroutine(breath());
    }
    private IEnumerator breath()
    {
        anim.SetBool(breathing, true);
        yield return new WaitForSeconds(10f);
        anim.SetBool(breathing, false);

    }
}
