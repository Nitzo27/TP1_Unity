using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationMouse : MonoBehaviour
{
    public float vitesse;
    private Vector3 targetPosition;
    private bool isMoving;
    const int bouton = 0;
    void Start()
    {
        targetPosition = transform.position;
        isMoving = false;
    }
    void Update()
    {
        if (Input.GetMouseButton(bouton))
            setPos();
        if (isMoving)
            bougeObj();
        
    }
    void setPos()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0;
        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);
        isMoving = true;
    }
    void bougeObj()
    {
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, vitesse * Time.deltaTime);
        if (transform.position == targetPosition)
            isMoving = false;

    }

}
