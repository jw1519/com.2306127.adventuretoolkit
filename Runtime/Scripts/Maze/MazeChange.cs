using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhysicsPuzzle
{
    public class MazeChange : MonoBehaviour
    {
        public Transform Wall1;
        public Transform Wall2;
        public Transform Wall3;
        public Transform Wall4;
        public Transform Wall5;
        public Transform Wall6;

        public static MazeChange instance;
        public void Awake()
        {
            if (instance == null)
                instance = this;
            else if (instance != this)
                Destroy(gameObject);
        }

        public void ChangeMaze() //changes the position and scale of the walls
        {
            Wall1.transform.localScale = new Vector3(0.5f, 5, 0.025f);
            Wall1.transform.localPosition = new Vector3(-0.072f, 2.8f, -0.485f);

            Wall2.transform.localPosition = new Vector3(0.25f, 2.8f, -0.275f);

            Wall3.transform.localScale = new Vector3(0.1f, 5, 0.025f);
            Wall3.transform.localPosition = new Vector3(-0.2f, 2.8f, -0.05f);

            Wall4.transform.localPosition = new Vector3(-0.043f, 2.8f, -0.367f);

            Wall5.transform.localPosition = new Vector3(-0.289f, 2.8f, -0.177f);

            Wall6.transform.localScale = new Vector3(0.7f, 5, 0.025f);
            Wall6.transform.localPosition = new Vector3(-0.49f, 3.23f, -0.09f);

        }

    }
}
