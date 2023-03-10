using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        } 

        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
