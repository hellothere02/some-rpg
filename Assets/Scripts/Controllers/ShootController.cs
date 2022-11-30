using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.Architecture.Mechanics
{
    public class ShootController : MonoBehaviour
    {
        [SerializeField]
        private Entity unit;

        private IShootComponent shootComponent;

        private void Awake()
        {
            this.shootComponent = this.unit.Get<IShootComponent>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            shootComponent.Shoot();
        }
    }
}