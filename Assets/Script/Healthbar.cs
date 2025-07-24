using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour

{
    private Image image;

    public float health = 100;
    
    private void Start()
    {
        image = GetComponent<Image>();
    }

   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
           {
            ChangeHealth(-10);
           } 
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ChangeHealth(10);
        }
    }

    public void ChangeHealth(float changeAmount)
    {
        health += changeAmount;
        image.fillAmount = health / 100;
    }
    
}
