using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{   
    public Transform cub;
    private Color rend;


    void Start()
    {
      rend = GetComponent<Renderer>().material.color;

    }
        void OnMouseOver()
    {
        cub.GetComponent<Renderer>().material.color = Color.black;
    }
     void OnMouseExit()
     {
      cub.GetComponent<Renderer>().material.color = rend;
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
