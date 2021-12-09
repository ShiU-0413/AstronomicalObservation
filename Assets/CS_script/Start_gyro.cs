using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_gyro : MonoBehaviour
{
    public static Quaternion gyro_value;

    public static Quaternion Get_gyro()
    {
        return gyro_value;
    }
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180f, Vector3.forward);
        gyro_value = Input.gyro.attitude;
    }
}
