using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class JumpController : MonoBehaviour
    {
        [SerializeField]
        private Entity unit;

        private IJumpComponent jumpComponent;

        private void Awake()
        {
            jumpComponent = unit.Get<IJumpComponent>();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }
        }

        private void Jump()
        {
            jumpComponent.Jump();
        }
    }
}
