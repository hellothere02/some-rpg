using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class JumpMechanics : MonoBehaviour
    {
        [SerializeField]
        private Vec3EventReceiver jumpReceiver;

        [SerializeField]
        private Vec3Behaviour jumpDirection;

        [SerializeField]
        private GameObject playerVisual;

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
            playerVisual.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpDirection.Value.y,0), ForceMode.Impulse);
        }
    }
}
