using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] Transform target;

    void Update()
    {
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
