using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth = 1;
    public float currentHealth;
    public float decayRate = 0.001f;

    public HealthBar healthBar;
    public Blackout blackout;

    void Start() 
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    // Called once per frame
    void Update()
    {
        Decay(decayRate);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(0.02f);
        }

        if(currentHealth <= 0)
        {
            GameOver();
        }
    }   

    void Decay(float decayRate)
    {
        currentHealth -= decayRate;
        healthBar.SetHealth(currentHealth);

        Blackout blackout = GetComponent<Blackout>();
        blackout.SetTransparency(currentHealth);
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
