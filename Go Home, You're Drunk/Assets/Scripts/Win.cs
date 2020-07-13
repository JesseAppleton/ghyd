using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject box;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            Debug.Log("Winner!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }    
    }
}
