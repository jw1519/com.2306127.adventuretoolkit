using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace PhysicsPuzzle
{
    public class MazeController : MonoBehaviour
    {
        public float rotationSpeed = 15f;
        public float rotationLimit = 45f;
        private float currentXRotation = 0f;
        private float currentZRotation = 0f;
        private void Start()
        {
            currentXRotation = 0f;
            currentZRotation = 0f;
        }
        // Update is called once per frame
        void Update()
        {
            //Get keyboard input for maze rotation
            float xInput = Input.GetAxis("Vertical"); //up and down arrow keys
            float zInput = Input.GetAxis("Horizontal"); //left and right keys

            //calculate rotation angles
            currentXRotation += xInput * rotationSpeed * Time.deltaTime;
            currentZRotation += zInput * rotationSpeed * Time.deltaTime;

            //clamp the rotation angles with limits
            currentXRotation = Mathf.Clamp(currentXRotation, -rotationLimit, rotationLimit);
            currentZRotation = Mathf.Clamp(currentZRotation, -rotationLimit, rotationLimit);

            //Apply the updated rotation
            transform.rotation = Quaternion.Euler(currentXRotation, 0f, currentZRotation);
        }
    }
}
