using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnOffKey : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    public GameObject cube1;
    public float speed = 5.0f;



    void Start()
    {
        
    }
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.V)){
        cube1.transform.Rotate(xAngle*speed, yAngle*speed, zAngle*speed, Space.Self);
	 }
    }
}
