using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godskripte : MonoBehaviour
{
    [SerializeField]
    GameObject placeholder = null;
    public static Godskripte x;
    public bool godbool1 = false;
    public bool godbool2 = false;
    public bool godbool3 = false;
    public bool godbool4 = false;
    public bool godbool5 = false;

    // Start is called before the first frame update
    void Start()
    {
        x = this;

    }

    // Update is called once per frame

    void Lightniningpower()
    {

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnPosition.z = 0.0f;
            GameObject objectInstance = Instantiate(placeholder, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
    }
}