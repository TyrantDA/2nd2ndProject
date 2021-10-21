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
    private Animator anim;
    private string Walk_Animation = "walk";
    private string jump_Animation = "jump";

    private bool jumpping = false;

    private Rigidbody2D mybody;

    private SpriteRenderer sr;

    private bool Isground = true;
    private bool wanderDirection = true;

    [SerializeField]
    private GameObject angel;

    [SerializeField]
    private int wounds;

    private bool wounded;
    public bool saved;
    public bool dead;
    private bool inWater;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        int num = rand.Next(10);
        wounded = false;
        jumpping = false;
        saved = false;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Godskripte.x.isbread)
        {
            wander();
        }
        if (Godskripte.x.isbread)
        {
            if(transform.position.x < Godskripte.x.breadx)
            {
                if(MoveForce == 1f)
                {
                    transform.position += new Vector3(MoveForce, 0f, 0f) * Time.deltaTime * speedLemming;
                }
                else
                {
                   MoveForce *= -1f;
                }

            }
            if (transform.position.x > Godskripte.x.breadx)
            {
                if (MoveForce == -1f)
                {
                    transform.position += new Vector3(MoveForce, 0f, 0f) * Time.deltaTime * speedLemming;
                }
                else
                {
                    MoveForce *= -1f;
                }


                transform.position += new Vector3(MoveForce, 0f, 0f) * Time.deltaTime * speedLemming;

            }
        }

        Animateplayer();

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

        if(saved)
        {
            death2();
        }

        if (inWater)
        {
            Physics2D.gravity = new Vector2(0f, -2.0f);
        }
    }
    void Animateplayer()
    {

        
        if (jumpping)
        {
            anim.SetBool(jump_Animation, true);
        }
        else
        {
            anim.SetBool(jump_Animation, false);
            if (MoveForce > 0)
            {
                anim.SetBool(Walk_Animation, true);
                sr.flipX = false;
            }
            else if (MoveForce < 0)
            {
                anim.SetBool(Walk_Animation, true);
                sr.flipX = true;
            }
            else
            {
                anim.SetBool(Walk_Animation, false);
            }

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
            jumpping = true;
            StartCoroutine(WaitTime());

        }

    }

    void death()
    {
        dead = true;
        Instantiate(angel, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    public void death2()
    {
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
            Godskripte.x.isbread = false;
            MoveForce *= -1f; 
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("water"))
        { 
            wounded = true;
            inWater = true;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            wounded = true;
        }

        if (collision.gameObject.CompareTag("barrier"))
        {
            Invoke("Playerjump", 0.1f);
        }
        if (collision.gameObject.CompareTag("end"))
        {
            saved = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("water"))
        {
            wounded = false;
            inWater = false;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            wounded = false;
        }
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);
        jumpping = false;
    }

} //class