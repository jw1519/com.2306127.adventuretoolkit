using PhysicsPuzzle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeManager : MonoBehaviour
{
    public GameObject maincamera;
    public GameObject mazeCamera;
    public GameObject ui;
    public GameObject maze;
    public GameObject player;
    public GameObject mazeCanvas;


    private void Start()
    {
        mazeCamera.SetActive(false);
        maincamera.SetActive(true);
    }
    public void StartMaze()
    {
        mazeCamera.SetActive(true);
        maincamera.SetActive(false);
        ui.SetActive(false);
        maze.GetComponent<MazeController>().enabled = true;
        player.SetActive(false);
        mazeCanvas.SetActive(true);
    } 
    public void Exit()
    {
        mazeCamera.SetActive(false);
        maincamera.SetActive(true);
        ui.SetActive(true);
        maze.GetComponent<MazeController>().enabled = false;
        player.SetActive(true);
        mazeCanvas.SetActive(false);
    }
}
