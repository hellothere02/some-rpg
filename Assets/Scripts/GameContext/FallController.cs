using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallController : MonoBehaviour, IConstructListener,
    IStartGameListener,
    IFinishGameListener
{
    private CharacterService characterService;
    private Transform playerTransform;
    private GameContext gameContext;

    private void Awake()
    {
        enabled = false;
    }

    void IConstructListener.Construct(GameContext context)
    {
        characterService = context.GetService<CharacterService>();
        gameContext = context;
    }

    void IStartGameListener.OnStartGame()
    {
        playerTransform = characterService.GetCharacterTransform();
        enabled = true;
    }

    void IFinishGameListener.OnFinishGame()
    {
        enabled = false;
    }

    private void Update()
    {
        if(playerTransform.position.y < -5)
        {
            gameContext.FinishGame();
        }
    }
}
