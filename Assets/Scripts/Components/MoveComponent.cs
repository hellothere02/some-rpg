using UnityEngine;

    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField]
        private Vector3EventReceiver moveReceiver;
    
        public void Move(Vector3 vector)
        {
            this.moveReceiver.Call(vector);
        }
    }