using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarMove : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private float accel;
    [SerializeField] private float maxAccel;
    [SerializeField] private float maxReverse;

    private bool forwardGear = true;
    private Vector3 steering;


    private Rigidbody rbody;

    [SerializeField] CarButton carButton;


    private void Awake()
    {

        if (!TryGetComponent<Rigidbody>(out rbody))
        {
            Debug.Log("U need a rigidbody");

        }

        accel = 0;
    }


    // Start is called before the first frame update
    void Start()
    {
        //subscribe to deceleration and acceleration events
        CarButton.changeAccelEvent += Accelerate;
        // subscribe to steering evnets.
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.forward * speed * accel * Time.deltaTime;
        move = move.normalized;
        rbody.velocity = move;
    }
    private void Accelerate(float _accel)
        {
            accel += _accel;
            accel = Mathf.Clamp(accel, maxReverse, maxAccel);
            //change the value dpeending on current direction
            //value of acceraltion
            //Debug.Log("Accelerating");
        }
    }
