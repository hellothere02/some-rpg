using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerService : MonoBehaviour
{
    [SerializeField] TimerBehaviour timer;
   public TimerBehaviour GetTimer()
    {
        return timer;
    }
}
