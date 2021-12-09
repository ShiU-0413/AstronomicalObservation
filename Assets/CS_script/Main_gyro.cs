using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_gyro : MonoBehaviour
{
    private Quaternion Gyro_initial;
    private Quaternion Inputgyro;

    // Start is called before the first frame update
    void Start()
    {
        Gyro_initial = Start_gyro.Get_gyro();
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Inputgyro = Quaternion.AngleAxis(136f, Vector3.right) * Quaternion.Inverse(Gyro_initial) * Input.gyro.attitude * Quaternion.AngleAxis(-180f,Vector3.back);
        transform.localRotation = Inputgyro;
    }
}
