using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammo : MonoBehaviour

{

    private int ammoCount;
    [SerializeField] Text ammoText;
    private object inputField;



    // Start is called before the first frame update
    void Start()
    {
        ammoCount = 69420;
        ammoText.text = "Current Ammo: " + ammoCount;
    }
    private void ReduceAmmo()
    {
        ammoCount -= 10;
        ammoText.text = "Current ammo" + ammoCount;
    }
    public void IncreaseAmmo()
    {

        ammoCount += int.Parse((string)inputField);
        ammoText.text = "Current Ammo:" + ammoCount;
    }

}

