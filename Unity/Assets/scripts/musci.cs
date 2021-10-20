using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musci : MonoBehaviour
{
    public AudioClip clip;
    public float volume = 6;


    void Start()
    {
        AudioSource.PlayClipAtPoint(clip, transform.position, volume);
    }
}
