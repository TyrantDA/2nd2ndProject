using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areyousurebox : MonoBehaviour

{
    [SerializeField]
    GameObject areyou = null;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Time.timeScale = 0;
        Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPosition.z = 0.0f;
        spawnPosition.x += +9f;
        spawnPosition.y += +3f;

        GameObject objectInstance3 = Instantiate(areyou, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
