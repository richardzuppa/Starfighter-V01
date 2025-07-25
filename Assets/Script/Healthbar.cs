using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour

{
    private Image image;

    private float health = 100;
    
    private void Start()
    {
        image = GetComponent<Image>();
    }

    public void ChangeHealth(float changeAmount)
    {
        health += changeAmount;
        image.fillAmount = health / 100;
    }
    
    public void DimHealth()
    {
         ChangeHealth(-0.1f);
    }

    public void SumHealth()
    {
         ChangeHealth(5);
    }
}
