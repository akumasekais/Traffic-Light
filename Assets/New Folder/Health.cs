using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    [Range(0f, 100f)]
    public float health;

    private float healthNormalized;

    public Image healthBar;

    public Image healthSplat;

    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        float healthFlip = 1 - healthNormalized;
        healthSplat.color = new Color(healthSplat.color.r, healthSplat.color.g, healthSplat.color.b, healthFlip);
        healthNormalized = health / 100;
        healthBar.fillAmount = healthNormalized;
        healthText.text = "Current Health" + health; 
    }

    // Update is called once per frame
    void Update()
    {
        float healthFlip = 1 - healthNormalized;
        healthSplat.color = new Color(healthSplat.color.r, healthSplat.color.g, healthSplat.color.b, healthFlip);
        healthNormalized = health / 100;
        healthBar.fillAmount = healthNormalized;
        healthText.text = "Current Health" + health;
    }
}
