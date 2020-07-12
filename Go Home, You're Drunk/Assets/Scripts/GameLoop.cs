using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public bool gameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        // public float playerHealth = GetComponent<PlayerStats>().currentHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if(gameEnd)
        {
            Debug.Log("Game Over!");
        }
    }
}
