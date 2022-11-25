using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    class Vec3Behaviour : MonoBehaviour
    {
        [SerializeField]
        private Vector3 value;

        public Vector3 Value { get => value; set => this.value = value; }
    }
}

