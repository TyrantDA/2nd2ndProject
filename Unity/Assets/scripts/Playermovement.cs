using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Playermovement : MonoBehaviour
{
    [SerializeField]
    private float MoveForce;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private float speedLemming;
    [SerializeField]
    private float jumpLemming;

    private float movementX;

    private Rigidbody2D mybody;

    private SpriteRenderer sr;

    private bool Isground = true;
    private bool wanderDirection = true;

    [SerializeField]
    private GameObject angel;

    [SerializeField]
    private int wounds;

    private bool wounded;

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
        wounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        //playerMoveKeyboard();
        wander();
        if(wounded)
        {
            wounds--;
        }

        if (wounds <= 0)
        {
            death();
        }

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

    void death()
    {
        Instantiate(angel, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Isground = true;

        }
       
        if (collision.gameObject.CompareTag("KillBox"))
        {
            // need to be careful happen lemming to close together my course errors
            death();
        }
        if (collision.gameObject.CompareTag("wall"))
        {
            MoveForce *= -1f; 
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("water"))
        { 
            wounded = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            wounded = true;
        }

        if (collision.gameObject.CompareTag("barrier"))
        {
            Invoke("Playerjump", 4f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("water"))
        {
            wounded = false;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            wounded = false;
        }

    }
} //class