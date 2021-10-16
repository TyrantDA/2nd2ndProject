using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angel : MonoBehaviour
{
    [SerializeField]
    private float MoveForce;
    [SerializeField]
    private float speedLemming;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3( 0f, MoveForce, 0f) * Time.deltaTime * speedLemming;
    }
}
