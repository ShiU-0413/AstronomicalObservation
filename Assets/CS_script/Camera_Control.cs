using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera_Control : MonoBehaviour
{
    public GameObject System;
    public GameObject Surface;
    public GameObject Static_Camera;
    public GameObject Observer_Camera;

    public int Status;
    private int Status_flag;

    // Start is called before the first frame update
    void Start()
    {
        Status = System.GetComponent<Toggle_Control>().Status;
        Observer_Camera = System.GetComponent<Toggle_Control>().Observer_Camera;
        Status_flag = 1;
    }

    void Update()
    {
        Status = System.GetComponent<Toggle_Control>().Status;
        Observer_Camera = System.GetComponent<Toggle_Control>().Observer_Camera;


        if(Status == Status_flag)
        {
            Status_flag = Status;
        }

        if (Status != Status_flag)
        {
            if (Status == 1)
            {
                Surface.SetActive(true);
                Static_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);

            }
            if(Status == 2)
            {
                //Surface.SetActive(false);
                Static_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0.01f, 0.01f, 0.3f, 0.3f);
                
            }

            Status_flag = Status;
        }

        //Debug.Log(Status);
    }
}
