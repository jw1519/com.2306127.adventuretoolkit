using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsPuzzle
{
    public class BallManager : MonoBehaviour
    {
        public static BallManager instance;
        public GameObject ball;
        public Transform spawnLocation;

        public void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
        }
        public void SpawnNewBall()
        {
            if (ball && spawnLocation)
            {
                Instantiate(ball, spawnLocation.position, Quaternion.identity);
            }
        }
    }
}
