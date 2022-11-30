using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class JumpComponent : MonoBehaviour, IJumpComponent
    {
        [SerializeField]
        private EventReceiver jumpReceiver;

        public void Jump()
        {
            jumpReceiver.Call();
        }
    }
}
