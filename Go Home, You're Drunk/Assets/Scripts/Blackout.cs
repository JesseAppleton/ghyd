using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blackout : MonoBehaviour
{
    public Image image;
    public float currentAlpha;

    // Use this for initialization
    void Start (){
        image = this.GetComponent<Image>();
    }

    public void SetTransparency(float incomingAlpha){
        Color alpha = image.color;
        alpha.a = incomingAlpha;
        currentAlpha = alpha.a;
        image.color = alpha;
    }

}
