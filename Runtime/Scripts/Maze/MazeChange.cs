using UnityEngine;

namespace PhysicsPuzzle
{
    public class MazeChange : MonoBehaviour
    {
        public Transform wall1;
        public Transform wall2;
        public Transform wall3;
        public Transform wall4;
        public Transform wall5;
        public Transform wall6;

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
            wall1.transform.localScale = new Vector3(0.5f, 5, 0.025f);
            wall1.transform.localPosition = new Vector3(-0.072f, 2.8f, -0.485f);

            wall2.transform.localPosition = new Vector3(0.25f, 2.8f, -0.275f);

            wall3.transform.localScale = new Vector3(0.1f, 5, 0.025f);
            wall3.transform.localPosition = new Vector3(-0.2f, 2.8f, -0.05f);

            wall4.transform.localPosition = new Vector3(-0.043f, 2.8f, -0.367f);

            wall5.transform.localPosition = new Vector3(-0.289f, 2.8f, -0.177f);

            wall6.transform.localScale = new Vector3(0.7f, 5, 0.025f);
            wall6.transform.localPosition = new Vector3(-0.49f, 3.23f, -0.09f);

        }

    }
}
