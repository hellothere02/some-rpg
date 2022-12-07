using UnityEngine;

    public sealed class Enemy : MonoBehaviour
    {
        [SerializeField]
        private IntEventReceiver takeDamageReceiver;
            
        public void TakeDamage(int damage)
        {
            this.takeDamageReceiver.Call(damage);
        }
    }