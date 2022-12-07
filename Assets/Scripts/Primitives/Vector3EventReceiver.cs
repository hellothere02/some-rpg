using System;
using Sirenix.OdinInspector;
using UnityEngine;

public class Vector3EventReceiver : MonoBehaviour
{
    public event Action<Vector3> OnEvent;

    [Button]
    public void Call(Vector3 point)
    {
        OnEvent?.Invoke(point);
    }
}