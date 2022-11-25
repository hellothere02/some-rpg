using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootMechanics : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver shootReceiver;
        [SerializeField]
        private GameObject bulletPref;
        [SerializeField]
        private Transform gunTransform;

        private void OnEnable()
        {
            shootReceiver.OnEvent += Shoot;
        }

        private void OnDisable()
        {
            shootReceiver.OnEvent -= Shoot;
        }

        private void Shoot()
        {
            Instantiate(bulletPref, gunTransform.position, Quaternion.identity);
        }
    }
}
