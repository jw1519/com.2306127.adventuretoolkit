using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace charactercontroller
{
    public class thirdPersonController : MonoBehaviour
    {
        public float movementSpeed = 3.0f;
        public float rotationspeed = 100.0f;

        private float gravity = -9.81f;//earths gravity
        private CharacterController characterController;
        private NavMeshAgent Player;
        private Vector3 Velocity;
        private Animator Animator;

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
            Player = GetComponent<NavMeshAgent>();
            Animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = new Vector3(0, 0, vertical).normalized;

            //rotate character
            if (horizontal != 0)
            {
                transform.Rotate(Vector3.up, horizontal * rotationspeed * Time.deltaTime);
                Player.ResetPath();
            }
            //move character
            if (direction.magnitude >= 0.1f)
            {
                if (vertical >= 0)
                {
                    Player.Move(transform.forward * vertical * movementSpeed * Time.deltaTime);
                    Player.ResetPath();
                }
                else
                {
                    Player.Move(-transform.forward * -vertical * movementSpeed * Time.deltaTime);
                    Player.ResetPath();
                }
                //updates animation peramitors
                if (Animator != null)
                {
                    Animator.SetFloat("speed", Mathf.Abs(vertical));
                    Animator.SetFloat("direction", horizontal);
                }
            }

            //gravity apply
            if (characterController.isGrounded && Velocity.y < 0)
            {
                Velocity.y = 0;
            }

            Velocity.y += gravity * Time.deltaTime;
            Player.Move(Velocity * Time.deltaTime);


        }
    }
}
