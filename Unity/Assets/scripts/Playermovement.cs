using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]
    private float MoveForce = 1f;
    [SerializeField]
    private float jumpForce = 1f;
    [SerializeField]
    private float speedLemming = 0.1f;
    [SerializeField]
    private float jumpLemming = 1f;

    private float movementX;

    private Rigidbody2D mybody;

    private SpriteRenderer sr;

    private bool Isground = true;
    private bool wanderDirection = true;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        int num = rand.Next(10);

        if (num <= 4)
        {
            wanderDirection = false;
        }
        else
        {
            wanderDirection = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //playerMoveKeyboard();
        wander();
    }

    void playerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * MoveForce;
        Playerjump();

    }

    void wander()
    {       
            transform.position += new Vector3(MoveForce, 0f, 0f) * Time.deltaTime * speedLemming;
    }
    private void FixedUpdate()
    {
    }
  
    void Playerjump()
    {
        if (Isground == true)
        {
            mybody.AddForce( new Vector2(0f, jumpForce)* jumpLemming, (ForceMode2D.Impulse));
            Isground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Isground = true;

        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("wall"))
        {
            MoveForce *= -1f; 
        }
        if(collision.gameObject.CompareTag("barrier"))
        {
            Playerjump();
        }

    }
} //class