using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toungdiescrpit : MonoBehaviour
{
    // Start is called before the first frame update
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
