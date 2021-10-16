using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godmove : MonoBehaviour
{
    [SerializeField]
    private float MoveForce = 10;
    private float movementX;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        godmovekey();
    }
    void godmovekey()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * MoveForce;
    }
}
