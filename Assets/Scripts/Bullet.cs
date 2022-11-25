using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 10, ForceMode.Impulse);
    }
}
