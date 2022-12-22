using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCompinent : MonoBehaviour, IPositionCompinent
{
    [SerializeField] private Transform position;
    public Vector3 GetPosition()
    {
        return position.position;
    }
}
