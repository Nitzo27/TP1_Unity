using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    string lettre_plus = "+";
    string lettre_moins = "-";
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
            transform.Rotate(transform.position.x,0f, 0f);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(transform.position.y, 0f,0f);
        }

            if (Input.inputString == lettre_plus){
           Camera.main.fieldOfView += 1;
		}
         if (Input.inputString == lettre_moins){
           Camera.main.fieldOfView -= 1;
		}
    }
}
