using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    [SerializeField] private GameObject[] lemmings;
    int i = 0;
    int save;
    int lemNum = 4;
    float x, y;
    int hold;
    System.Random r;

    // Start is called before the first frame update
    void Start()
    {
        save = 0;
        x = -4.29f;
        y = -1.46f;
        hold = 0;
        r = new System.Random();
        Debug.Log("start");
       
        for (int i = 0; i < lemNum; i++)
         {
                spawnLemming();
         }

    }

    void spawnLemming()
    {

        int l = r.Next(3);

        Debug.Log("in spawn function " + l);
        Instantiate(lemmings[l], new Vector3(x, y, 0f), transform.rotation);
        // spawn distance apart
        x = x - 0.10f;
    }



    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lemmings.Length; i++)
        {
            Playermovement hold = lemmings[i].GetComponent<Playermovement>();
            Debug.Log(hold.saved);
            if (hold.saved)
            {
                save++;
                Debug.Log("done");
            }
        }
    }
}
