using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class CursorMovementHuman : MonoBehaviour
    {
        Ray lastRay;

        void Update()
        {
            UpdateAnimator();
        }

        public void MoveTo(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
        }

        private void UpdateAnimator()
        {    
            Vector3 velocity = GetComponent<NavMeshAgent>().velocity;

            Vector3 local_velocity = transform.InverseTransformDirection(velocity);

            float speed = local_velocity.z;
  
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }
}
