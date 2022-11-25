using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class MoveMechanics : MonoBehaviour
    {
        [SerializeField]
        private Vec3EventReceiver moveReceiver;

        [SerializeField]
        private Vec3Behaviour vec3Points;

        [SerializeField]
        private GameObject playerVisual;

        private void OnEnable()
        {
            moveReceiver.OnEvent += Move;
        }

        private void OnDisable()
        {
            moveReceiver.OnEvent -= Move;
        }

        private void Move()
        {
            playerVisual.transform.position = vec3Points.Value;
        }
    }
}
