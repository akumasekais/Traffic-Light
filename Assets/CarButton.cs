using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CarButton : MonoBehaviour
{
    [SerializeField] private EventSystem eventSystem;
    [SerializeField] private GraphicRaycaster gRaycaster;

    //variable for how powerful accell is
    [SerializeField] private float accelRate;

    //variable for pointer data
    private PointerEventData pData;

    //event for changing car accell
    public delegate void ChangeAccel(float accel);
    public static ChangeAccel changeAccelEvent;

    private Image buttonSprite;
    //event for changing our acceleration 

    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<Image>(out buttonSprite))
        {
            Debug.Log("Attach this script to something with an mage component!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //LeftMouseClick getkey
        {
            MouseInteraction();
        }
        else
        {
            buttonSprite.color = Color.black;
        }
    }
    private void MouseInteraction()
    {
        //initialize a new pointerdata event
        pData = new PointerEventData(eventSystem);

        //asign the current position f the mouse on the UI as the positon for pData
        pData.position = Input.mousePosition;

        //Initialize a lit of raycast results
        List<RaycastResult> results = new List<RaycastResult>();

        //perform a graphic raycast from pointer position to the UI
        gRaycaster.Raycast(pData, results);

        foreach (RaycastResult result in results)
        {
            Debug.Log(result.gameObject.name);
            Image _buttonSprite;
            //if a button is detected then check if it is the accelerate butto then invoke change increase accel event with a positive value
            if (result.gameObject.tag == "ForwardButt")
            {
                changeAccelEvent(accelRate);
                if (result.gameObject.TryGetComponent<Image>(out _buttonSprite))
                {
                    _buttonSprite.color = Color.green;

                }
            }
            else if (result.gameObject.tag == "ReverseButt")
            {
                changeAccelEvent(-accelRate);
                if (result.gameObject.TryGetComponent<Image>(out _buttonSprite))
                {

                    _buttonSprite.color = Color.red;
                }
                // if its the decelerate button then invoke decrease accel with a negative value
            }
            

        }

    }

}
