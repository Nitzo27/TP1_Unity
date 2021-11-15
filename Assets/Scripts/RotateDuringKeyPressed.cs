using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDuringKeyPressed : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    public GameObject cube1;
    public float speed = 5.0f;
    public string lettre;

    void Start()
    {
        
    }
    void Update()
    {
     if (Input.inputString != lettre)
     {
        cube1.transform.Rotate(xAngle*speed, yAngle*speed, zAngle*speed, Space.Self);
        Debug.Log("La touche " +lettre+" a  press?");
	 }
        
    }
}
