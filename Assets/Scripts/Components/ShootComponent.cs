using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootComponent : MonoBehaviour, IShootComponent
    {
        [SerializeField]
        private EventReceiver shootReceiver;

        public void Shoot()
        {
            shootReceiver.Call();
        }
    }
}