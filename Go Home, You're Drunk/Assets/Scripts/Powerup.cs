using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject pickupEffect;

    public float heal = 0.02f;
    public float duration = 4f;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine( Pickup(other) );
        }
    }

    IEnumerator Pickup(Collider player)
    {
        // Spawn effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Apply effect to player
        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.currentHealth += heal;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        // Wait x seconds
        yield return new WaitForSeconds(duration);
        
        // wear off
        // stats.currentHealth /= heal;

        // remove powerup
        Destroy(gameObject);
    }

    
}
