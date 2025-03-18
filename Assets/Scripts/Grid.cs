using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Grid : MonoBehaviour
    {
        public float cellSize = 1.0f;
        private Dictionary<Vector3Int, GameObject> gameObjects = new Dictionary<Vector3Int, GameObject>();
        private Dictionary<Vector2Int, Vector3> gridToWorldDict = new Dictionary<Vector2Int, Vector3>();

        // Add
        public bool Add(Vector3Int tileCoordinates, GameObject gameObject)
        {
            if (gameObjects.ContainsKey(tileCoordinates)) return false;

            gameObjects.Add(tileCoordinates, gameObject);
            return true;
        }

        // Remove
        public void Remove(Vector3Int tileCoordinates)
        {
            if (!gameObjects.ContainsKey(tileCoordinates)) return;

            Destroy(gameObjects[tileCoordinates]);
            gameObjects.Remove(tileCoordinates);
        }

        // WorldToGrid
        public Vector2Int WorldToGrid(Vector3 worldPosition)
        {
            int x = Mathf.FloorToInt(worldPosition.x / cellSize);
            int y = Mathf.FloorToInt(worldPosition.z / cellSize);
            return new Vector2Int(x, y);
        }

        // GridToWorld
        public void GridToWorld(Vector3Int tileCoordinates)
        {
            
        }
    }
}