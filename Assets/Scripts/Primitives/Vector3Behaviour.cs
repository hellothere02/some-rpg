using System;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class Vector3Behaviour : MonoBehaviour
    {
        [SerializeField]
        private Vector3 value;

        public Vector3 Value { get => value; set => this.value = value; }
    }
}

