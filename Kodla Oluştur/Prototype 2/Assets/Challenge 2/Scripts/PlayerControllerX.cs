using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTimeKeyPressed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.realtimeSinceStartup - lastTimeKeyPressed > 2)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastTimeKeyPressed = Time.realtimeSinceStartup;
            }
        }
    }
}
