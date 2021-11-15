using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{   
    
    public Color r;


    private Color rend;


    void Start()
    {
      rend = GetComponent<Renderer>().material.color;

    }
        void OnMouseOver()
    {
        
        transform.GetComponent<Renderer>().material.color = r;
        
    }
     void OnMouseExit()
     {
      transform.GetComponent<Renderer>().material.color = rend;
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
