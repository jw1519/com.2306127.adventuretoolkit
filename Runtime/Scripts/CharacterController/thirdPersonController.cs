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
        private NavMeshAgent player;
        private Vector3 velocity;
        private Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
            player = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
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
                player.ResetPath();
            }
            //move character
            if (direction.magnitude >= 0.1f)
            {
                if (vertical >= 0)
                {
                    player.Move(transform.forward * vertical * movementSpeed * Time.deltaTime);
                    player.ResetPath();
                }
                else
                {
                    player.Move(-transform.forward * -vertical * movementSpeed * Time.deltaTime);
                    player.ResetPath();
                }
                //updates animation peramitors
                if (animator != null)
                {
                    animator.SetFloat("speed", Mathf.Abs(vertical));
                    animator.SetFloat("direction", horizontal);
                }
            }
            //gravity apply
            if (characterController.isGrounded && velocity.y < 0)
            {
                velocity.y = 0;
            }
            velocity.y += gravity * Time.deltaTime;
            player.Move(velocity * Time.deltaTime);
        }
    }
}
