using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsPuzzle
{
    public class Ball : MonoBehaviour
    {

        public GameObject ballPrefab;

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("PlayArea"))
            {
                Debug.Log("Out of bounds");
                Destroy(ballPrefab);
                BallManager.instance.SpawnNewBall(); //call BallManager to spawn a new ballsw
            }
        }
    }
}
