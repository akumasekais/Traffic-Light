using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CarSteer : MonoBehaviour
{
    [SerializeField] private float steerPos;
    [SerializeField] private Image steerImage;
    [SerializeField] private float leftSteerMax;
    [SerializeField] private float rightSteerMax;

    [SerializeField] private EventSystem eventSystem;
    [SerializeField] private GraphicRaycaster gRaycaster;
    private PointerEventData pData;

    private float mouseDir;

    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Image>(out steerImage))
        {
            Debug.Log("you need an image coponent on this object!");
        }
    }


    // Update is called once per frame
    void Update()
    {

        mouseDir = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            Steering();
        }
        else
        {
            //if(steerImage.transform.position.x != steerPos)
            {
                steerImage.transform.position = Vector3.Lerp(steerImage.transform.position, new Vector3(steerPos, 50, 0), 2 * Time.deltaTime);
            }
        }
    }
    private void Steering()
    {
        pData = new PointerEventData(eventSystem);

        pData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();

        gRaycaster.Raycast(pData, results);

        foreach (RaycastResult result in results)
        {
            if (result.gameObject.tag == "SteeringWheel")
            {
                steerImage.transform.position += new Vector3(mouseDir, steerImage.transform.position.y, 0);
                if (steerImage.transform.position.x < leftSteerMax)
                {
                    steerImage.transform.position = new Vector3(leftSteerMax, steerImage.transform.position.y, 0);

                }
                else if (steerImage.transform.position.x > rightSteerMax)
                {
                    steerImage.transform.position = new Vector3(rightSteerMax, steerImage.transform.position.y, 0);
                }

            }
        }
    }
}

