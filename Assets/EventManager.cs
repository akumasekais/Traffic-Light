using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        }
        else
        {
            Debug.Log("Only one instance of EventManager should exist");
        }
    }
    public delegate void LoseHealth(float _damage);
    public static LoseHealth loseHealthEvent;

    public delegate void GainHealth(float _damage);
    public static GainHealth gainHealthEvent;

    public delegate void ChangeLight(int LightID, string LightName);
    public static ChangeLight changeLightEvent;

    public delegate void IncreaseCarWaiting(int amount, string lightName);
    public static IncreaseCarWaiting increaseCarsWaitingEvent;

}

 