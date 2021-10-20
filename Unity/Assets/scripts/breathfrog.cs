using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathfrog : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    public string breathing = "isbreath";
    public string atack = "isattack";
    [SerializeField]
    GameObject toung = null;
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
        yield return new WaitForSeconds(3f);
        anim.SetBool(atack, true);
        yield return new WaitForSeconds(0.5f);

        Vector3 spawnPosition = transform.position;
        spawnPosition.z = 0.0f;
        spawnPosition.x += -1f;

        GameObject objectInstance = Instantiate(toung, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
        anim.SetBool(atack, false);
        yield return new WaitForSeconds(3f);
        going = false;



    }
}
