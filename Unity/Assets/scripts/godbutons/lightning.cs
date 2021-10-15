using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitTime());
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);

    }
}
