using UnityEngine;
using UnityEngine.AI;

namespace charactercontroller
{
    public class PontAndClick : MonoBehaviour
    {
        public NavMeshAgent Player;
        public Animator Animator;
        public float Rotationspeed = 100.0f;
        [SerializeField]
        private Vector3 target;

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //find mouse position
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    target = hit.point;
                    Player.SetDestination(target);
                }

            }
            if (Animator != null)
            {
                if (target != null)
                    Animator.SetFloat("speed", Player.velocity.magnitude);
            }
            float horizontal = Input.GetAxis("Horizontal");

            //rotate character
            if (horizontal != 0)
            {
                transform.Rotate(Vector3.up, horizontal * Rotationspeed * Time.deltaTime);
                Player.ResetPath();
            }
        }
    }
}
