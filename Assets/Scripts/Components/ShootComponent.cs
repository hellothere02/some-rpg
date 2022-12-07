using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class ShootComponent : MonoBehaviour, IShootComponent
    {
        [SerializeField]
        private EventReceiver shootReceiver;

        public void Shoot()
        {
            shootReceiver.Call();
        }
    }