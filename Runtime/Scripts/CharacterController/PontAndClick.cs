using UnityEngine;
using UnityEngine.AI;

namespace charactercontroller
{
    public class PontAndClick : MonoBehaviour
    {
        public NavMeshAgent player;
        public Animator animator;
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
                    player.SetDestination(target);
                }

            }
            if (animator != null)
            {
                if (target != null)
                    animator.SetFloat("speed", player.velocity.magnitude);
            }
        }
    }
}
