using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    // Start is called before the first frame update
    private bool pressed = false;
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        if (Godskripte.x.godbool2)
        {
            pressed = true;
            GetComponent<Rigidbody2D>().isKinematic = true;
        }
    }
    private void OnMouseUp()
    {
        pressed = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
    }
  
    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
        
    }
}
