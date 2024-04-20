using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class GravityControlLite : MonoBehaviour
{
    public Attractors[] gravityWells;

    [Serializable]
    public class Attractors
    {
        public Transform gravityWell;
        public float gravityModifier;
    }
}
