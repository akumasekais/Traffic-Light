using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCar : MonoBehaviour
{
    public string lightName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            EventManager.increaseCarsWaitingEvent(5, lightName);
            //invoke increase cars waiting event .. EventManager
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "car")
        {
            EventManager.increaseCarsWaitingEvent(-5, lightName);

        }
    }
}

