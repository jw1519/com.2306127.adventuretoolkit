using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsPuzzle
{
    public class OnEnterBox : MonoBehaviour
    {
        public GameObject boxTop;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Ball"))
            {
                Debug.Log("In the box");
                boxTop.SetActive(boxTop); //closes the box
                MazeChange.instance.ChangeMaze();
                BallManager.instance.SpawnNewBall();
            }
        }
    }
}
