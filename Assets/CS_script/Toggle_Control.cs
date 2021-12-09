using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Control: MonoBehaviour
{
    public GameObject Tog_Earth;
    public GameObject Tog_Cele;
    public GameObject Tog_Japan;
    public GameObject Tog_Singapole;
    public GameObject Tog_Brazil;
    public GameObject Tog_View_Earth;
    public GameObject Tog_View_Space;

    public GameObject Earth;
    public GameObject CeleSphere;

    public GameObject Ob_Japan;
    public GameObject Ob_Singapole;
    public GameObject Ob_Brazil;

    public GameObject Static_Camera;
    public GameObject Observer_Camera;

    public int Status;
    private int Status_flag;

    // Start is called before the first frame update
    void Start()
    {   
        Earth.GetComponent<SpinFree>().spin = true;

        Ob_Japan.SetActive(true);
        Ob_Singapole.SetActive(false);
        Ob_Brazil.SetActive(false);
        Observer_Camera = GameObject.Find("Camera_Japan");

        Status = 1;
        Status_flag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Tog_Earth.GetComponent<Toggle>().isOn)
        {
            Earth.GetComponent<SpinFree>().spin = true;
            CeleSphere.GetComponent<SpinFree>().spin = false;
        }
        if (Tog_Cele.GetComponent<Toggle>().isOn)
        {
            Earth.GetComponent<SpinFree>().spin = false;
            CeleSphere.GetComponent<SpinFree>().spin = true;
        }


        if (Tog_Japan.GetComponent<Toggle>().isOn)
        {
            if (Status == 1)
            {
                Ob_Japan.SetActive(true);
                Ob_Singapole.SetActive(false);
                Ob_Brazil.SetActive(false);
                Observer_Camera = GameObject.Find("Camera_Japan");
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);
            }
            if(Status == 2)
            {
                Ob_Japan.SetActive(true);
                Ob_Singapole.SetActive(false);
                Ob_Brazil.SetActive(false);
                Observer_Camera = GameObject.Find("Camera_Japan");
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0.01f, 0.01f, 0.3f, 0.3f);
            }
        }
        
        if (Tog_Singapole.GetComponent<Toggle>().isOn)
        {
            if (Status == 1)
            {
                Ob_Japan.SetActive(false);
                Ob_Singapole.SetActive(true);
                Ob_Brazil.SetActive(false);
                Observer_Camera = GameObject.Find("Camera_Singapole");
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);
            }
            if (Status == 2)
            {
                Ob_Japan.SetActive(false);
                Ob_Singapole.SetActive(true);
                Ob_Brazil.SetActive(false);
                Observer_Camera = GameObject.Find("Camera_Singapole");
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0.01f, 0.01f, 0.3f, 0.3f);
            }
        }

        if (Tog_Brazil.GetComponent<Toggle>().isOn)
        {
            if (Status == 1)
            {
                Ob_Japan.SetActive(false);
                Ob_Singapole.SetActive(false);
                Ob_Brazil.SetActive(true);
                Observer_Camera = GameObject.Find("Camera_Brazil");
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0, 0, 1, 1);
            }
            if (Status == 2)
            {
                Ob_Japan.SetActive(false);
                Ob_Singapole.SetActive(false);
                Ob_Brazil.SetActive(true);
                Observer_Camera = GameObject.Find("Camera_Brazil");
                Observer_Camera.GetComponent<Camera>().enabled = true;
                Observer_Camera.GetComponent<Camera>().rect = new Rect(0.01f, 0.01f, 0.3f, 0.3f);
            }
        }

        if (Tog_View_Earth.GetComponent<Toggle>().isOn)
        {
            Status = 1;
        }
        if (Tog_View_Space.GetComponent<Toggle>().isOn)
        {
            Status = 2;
        }
        

    }
}
