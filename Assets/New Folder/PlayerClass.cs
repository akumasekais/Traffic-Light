using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerClass : MonoBehaviour
{
    [SerializeField] private Text classText;

    [SerializeField] Image classBG;

    //erializeField] private List<string> classes = new List<string>();
    [SerializeField] private Dropdown classDrop;
    // Start is called before the first frame update
    void Start()
    {
        /*
     classes.Add("Knight");
    classes.Add("Rogue");
     classes.Add("Wizard");
        */
        classText.text = classDrop.options[classDrop.value].text;
        classBG.sprite = classDrop.options[classDrop.value].image;
    }  

    // Update is called once per frame
    void Update()
    {
        
    }
   public void UpdateClass ()
    {
        classText.text = classDrop.options[classDrop.value].text;
        classBG.sprite = classDrop.options[classDrop.value].image;
    }
}
