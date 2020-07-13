using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public HealthBar healthBar;
    public Blackout blackout;
    public float maxHealth;
    public float currentHealth;
    public float decayRate;

    void Start(){
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        blackout.SetTransparency(0f);
    }

    // Called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            TakeDamage(2f);
        }

        if(currentHealth <= 0){
            GameOver();
        }

        Decay(decayRate);
    }   

    void Decay(float decayRate){
        currentHealth -= decayRate;
        healthBar.SetHealth(currentHealth);
        float transparency = ((maxHealth - currentHealth) / 1f);
        blackout.SetTransparency( transparency ); 
    }

    void TakeDamage(float damage){
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void GameOver(){
        Debug.Log("You lose!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
