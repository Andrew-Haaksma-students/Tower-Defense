using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace TowerDefense
{
    public class Enemy : MonoBehaviour
    {
        public Path path;
        public int index = 0;
        public float speed = 1f;
        public int damage = 1;
    }
}