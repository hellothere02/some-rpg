using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class JumpMechanics : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver jumpReceiver;

        [SerializeField]
        private Vector3Behaviour jumpDirection;

        [SerializeField]
        private Rigidbody targetRb;

        private void OnEnable()
        {
            jumpReceiver.OnEvent += Jump;
        }

        private void OnDisable()
        {
            jumpReceiver.OnEvent -= Jump;
        }

        private void Jump()
        {
            targetRb.AddForce(new Vector3(0, jumpDirection.Value.y,0), ForceMode.Impulse);
        }
    }
