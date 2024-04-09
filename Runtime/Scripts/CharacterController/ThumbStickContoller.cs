using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace charactercontroller
{
    public class ThumbStickContoller : MonoBehaviour
    {
        public float speed = 2.0f;
        public NavMeshAgent player;
        public Animator animator;
        public float rotationspeed = 100.0f;

        [SerializeField]
        Vector2 inputvalue;



        // Start is called before the first frame update
        void Start()
        {
            player = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {

            float horizontal = inputvalue.x;
            float vertical = inputvalue.y;

            Vector3 direction = new Vector3(0, 0, vertical).normalized;

            //rotate character
            if (horizontal != 0)
            {
                transform.Rotate(Vector3.up, horizontal * rotationspeed * Time.deltaTime);
                player.ResetPath();
            }

            //move character
            if (direction.magnitude >= 0.1f)
            {
                if (vertical >= 0)
                {
                    player.Move(transform.forward * vertical * speed * Time.deltaTime);
                    player.ResetPath();
                }
                else
                {
                    player.Move(-transform.forward * -vertical * speed * Time.deltaTime);
                    player.ResetPath();
                }
            }
            else
            {
                inputvalue = Vector2.zero;
            }
            if (animator != null)
            {
                animator.SetFloat("speed", Mathf.Abs(vertical));
                animator.SetFloat("direction", horizontal);
            }
        }
        void OnMove(InputValue value)
        {
            inputvalue = value.Get<Vector2>();
            Debug.Log(inputvalue);
        }
    }
}
