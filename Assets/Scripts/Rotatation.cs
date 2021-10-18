using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatation : MonoBehaviour
{
public float xAngle, yAngle, zAngle;
    public GameObject cube1;
    public float speed = 5.0f;

    void Start()
    {
        
    }
    void Update()
    {
        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
