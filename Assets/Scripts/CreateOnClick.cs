using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnClick : MonoBehaviour
{
    public Transform model1;
    public Transform model2;

    // Start is called before the first frame update
    void Start()
    {
       // model2.transform.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
            Debug.Log("bouton Fire 2 cliqué");


    }
}