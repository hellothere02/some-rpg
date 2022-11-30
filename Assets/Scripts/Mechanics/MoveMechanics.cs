using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveMechanics : MonoBehaviour
    {
        [SerializeField]
        private Vector3EventReceiver moveReceiver;        

        [SerializeField]
        private Transform targetOdject;

        private void OnEnable()
        {
            moveReceiver.OnEvent += Move;
        }

        private void OnDisable()
        {
            moveReceiver.OnEvent -= Move;
        }

        private void Move(Vector3 moveVector)
        {
            targetOdject.position += moveVector;
        }
    }
}
