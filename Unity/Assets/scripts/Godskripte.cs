using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godskripte : MonoBehaviour
{
    [SerializeField]
    GameObject placeholder = null;
    [SerializeField]
    GameObject lightningbox = null;
    [SerializeField]
    GameObject bread = null;
    [SerializeField]
    GameObject Fire = null;
    public static Godskripte x;
    public bool godbool1 = false;
    public bool godbool2 = false;
    public bool godbool3 = false;
    public bool godbool4 = false;
    public bool godbool5 = false;
    public bool Lightningcooldown = true;
    public bool isbread = false;
    public float breadx = 0f;

    // Start is called before the first frame update
    void Start()    
    {
        x = this;
        Lightningcooldown = false;
    }

    // Update is called once per frame

    void Lightniningpower()
    {

    }
    void Update()
    {
        if (godbool1)
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (Lightningcooldown)
                {
                    Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    spawnPosition.z = 0.0f;
                    spawnPosition.y = 0.55f;
                    GameObject objectInstance = Instantiate(placeholder, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    spawnPosition.y = 1.2f;
                    GameObject objectInstance2 = Instantiate(lightningbox, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    Lightningcooldown = false;
                    StartCoroutine(WaitTime());
                }
                else
                {
                    StartCoroutine(WaitTime());

                }

            }
        }
        if (godbool3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Lightningcooldown)
                {
                    Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    spawnPosition.z = 0.0f;
                    GameObject objectInstance3 = Instantiate(Fire, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    Lightningcooldown = false;
                    StartCoroutine(WaitTime());


                }
                else
                {
                    StartCoroutine(WaitTime());

                }

            }
        }
       if (godbool5)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Lightningcooldown)
                {
                    isbread = true;
                    Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    breadx = spawnPosition.x;
                    spawnPosition.z = 0.0f;
                    spawnPosition.y = 2f;
                    GameObject objectInstance3 = Instantiate(bread, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    Lightningcooldown = false;
                    StartCoroutine(WaitTime());


                }
                else
                {
                    StartCoroutine(WaitTime());

                }
            }

        }
    }

    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);
        Lightningcooldown = true;



    }

}
