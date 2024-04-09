using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

namespace charactercontroller
{
    public class PontAndClick : MonoBehaviour
    {
        public NavMeshAgent player;
        public Animator animator;
        [SerializeField]
        private Vector3 Target;

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //find mouse position
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    Target = hit.point;
                    player.SetDestination(Target);
                }

            }
            if (animator != null)
            {
                if (Target != null)
                    animator.SetFloat("speed", player.velocity.magnitude);
            }
        }
    }
}
