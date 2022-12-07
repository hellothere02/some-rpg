using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
