using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour

{
    private Image image;

    public float health = 10;
    
    private void Start()
    {
        image = GetComponent<Image>();
    }

   


    public void DimHealth()
    {
         ChangeHealth(1);
    }
    
    public void ChangeHealth(float changeAmount)
    {
        health += changeAmount;
        image.fillAmount = health / 10;
    }
    
}
