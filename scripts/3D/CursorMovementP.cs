using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CursorMovementP : MonoBehaviour
{
    [SerializeField] Transform target;

    Ray lastRay;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        bool isHit = Physics.Raycast(ray, out hit);
        if(isHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        } 
    }
}
