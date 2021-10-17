using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    [SerializeField] private GameObject[] lemmings;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        while(i < lemmings.Length)
        {
            Debug.Log(i);
            Invoke("spawnLemming", 5f);
  
        }
    }

    void spawnLemming()
    {
        Debug.Log("in spawn function");
        Instantiate(lemmings[i], new Vector3(-7.35f, -2.89f, 0f), transform.rotation);
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
