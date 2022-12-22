using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class GameLauncher : MonoBehaviour, IConstructListener
{
    private TimerBehaviour timer;
    private GameContext gameContext;

    void IConstructListener.Construct(GameContext context)
    {
        gameContext = context;
        timer = context.GetService<TimerService>().GetTimer();
    }

    [Button]
    public void StartGameWithDelay()
    {
        timer.OnEnded += gameContext.StartGame;
        timer.Play();
    }
}
