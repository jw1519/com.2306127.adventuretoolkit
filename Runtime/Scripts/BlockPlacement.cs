using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;
using Unity.AI.Navigation;

namespace TileMap
{

    public class BlockPlacement : MonoBehaviour
    {
        public int numberofblocks = 40;
        // Accessing Tile Prefabs
        public GameObject grass;
        public GameObject sand;
        public GameObject water;
        public GameObject grassAndTree;

        public Transform TileParent;
        public NavMeshSurface navMeshSurface;

        public float width = 5f;
        public float height = 5f;
        public float spacing = 5f;


        // Start is called before the first frame update
        void Start()
        {
            var random = new System.Random();
            var Blocklist = new List<GameObject> { grass, sand, water, grassAndTree }; // List of tiles used in the map

            for (int y = 0; y < width; y++)
            { 
                for (int x = 0; x < height; x++ )
                {
                    Vector3 pos = new Vector3(x, 0, y) * spacing;
                    int index = random.Next(Blocklist.Count);

                    GameObject prefabInstance = Instantiate(Blocklist[index]);
                    prefabInstance.transform.SetParent(TileParent);
                    prefabInstance.transform.position = pos;
                }
            }
            if (navMeshSurface != null)
            {
                navMeshSurface.BuildNavMesh();
            }
        }
    }
}
