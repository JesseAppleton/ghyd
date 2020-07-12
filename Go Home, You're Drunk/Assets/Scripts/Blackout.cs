using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blackout : MonoBehaviour
{
    public Image image;
    public float currentAlpha;
    public float maybeAlpha;

    // Use this for initialization
    void Start () 
    {
        image = this.GetComponent<Image>();
    }
    
    // Update is called once per frame
    void Update () 
    {
        Color alpha = image.color;
        alpha.a += 0.0001f; // SET THIS IN RELATION TO HEALTH
        currentAlpha = alpha.a;
        maybeAlpha = GetComponent<PlayerStats>().currentHealth % 1;
        image.color = alpha;
    }

    public void SetTransparency(float health)
    {
        // Color currentAlpha = image.color;
        // currentAlpha.a = health;
        // image.color = currentAlpha;
    }

}
