using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour

{

    private int ammoCount;
    private int ammoA;
    private int ammoB;
    private int ammoC;
    [SerializeField] Text ammoText;
    [SerializeField] private InputField inputField;

    delegate void AmmoPickUpDelegate();
    AmmoPickUpDelegate AmmoPickUp;

    void Start()
    {
        AmmoPickUp += GetAmmoA;
        AmmoPickUp += GetAmmoB;
        AmmoPickUp += GetAmmoC;

        ammoCount = 69420;
        ammoText.text = "Current Ammo: " + ammoCount;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AmmoPickUp();
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {

        }
    }
    public void ReduceAmmo()
    {
        ammoCount -= 10;
        ammoText.text = "Current ammo" + ammoCount;
    }
    public void IncreaseAmmo()
    {

        ammoCount += int.Parse(inputField.text);
        ammoText.text = "Current Ammo:" + ammoCount;
    }
    public void GetAmmoA()
    {
        ammoA++;
        Debug.Log("Got Ammo A");

    }
    public void GetAmmoB()
    {
        ammoB++;
        Debug.Log("Got Ammo B");
    }
    public void GetAmmoC()
    {
        ammoC++;
        Debug.Log("Got Ammo C");
    }
}

