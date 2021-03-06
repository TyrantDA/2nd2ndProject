using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExceptionHandlingCsharp
{
    public class SceneStart : MonoBehaviour
    {
        [SerializeField] private GameObject[] lemmings;
        int i = 0;
        int save;
        [SerializeField] int lemNum;
        [SerializeField] float LemmingDisplacement;
        [SerializeField] float x, y;
        int h;
        System.Random r;
        private GameObject[] lemList;
        private bool[] saved;
        private bool[] gone;
        private int counter, won, losed;

        // Start is called before the first frame update
        void Start()
        {
            save = 0;
            h = 0;
            r = new System.Random();
            Debug.Log("start");
            lemList = new GameObject[lemNum];
            saved = new bool[lemNum];
            gone = new bool[lemNum];
            counter = lemNum;

            for (int i = 0; i < lemNum; i++)
            {
                spawnLemming();
            }

        }

        void spawnLemming()
        {

            int l = r.Next(3);
            lemList[h] = Instantiate(lemmings[l], new Vector3(x, y, 0f), transform.rotation) as GameObject;
            // spawn distance apart
            x = x - LemmingDisplacement;
            h++;

        }



        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < lemList.Length; i++)
            {
                if (gone[i] != true && saved[i] != true)
                {
                    try
                    {
                        Playermovement hold = lemList[i].GetComponent<Playermovement>();
                        if (hold.saved)
                        {
                            save++;
                            saved[i] = true;
                            counter--;
                        }
                    }
                    catch (Exception ex)
                    {
                        gone[i] = true;
                        counter--;
                    }
                   
                }
            }

            Debug.Log(counter);
            if (counter == 0)
            {
                int c = 0;
                for (int j = 0; j < saved.Length; j++)
                {
                    if(saved[j] == true)
                    {
                        won++;
                    }
                }

                if(won > 0)
                {
                    Debug.Log("You have won");
                }
                else
                {
                    Debug.Log("You have lose");
                }
            }


        }
    }
}