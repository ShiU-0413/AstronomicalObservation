using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public GameObject Star;
    public GameObject Parent;
    public TrailRenderer Star_Trail;
    // Start is called before the first frame update
    void Start()
    {
        Parent = GameObject.Find("Stars");

        for(int i=0; i<70; ++i)
        {
            GameObject Star = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Star.transform.parent = Parent.transform;
            Star.transform.position = Random.onUnitSphere * 12.5f;
            Star.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
