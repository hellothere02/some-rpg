using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallController : MonoBehaviour, IConstructListener,
    IStartGameListener,
    IFinishGameListener
{
    private CharacterService characterService;
    private IPositionCompinent positionCompinent;
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
        positionCompinent = characterService.GetCharacter().Get<IPositionCompinent>();
        enabled = true;
    }

    void IFinishGameListener.OnFinishGame()
    {
        enabled = false;
    }

    private void Update()
    {
        if(positionCompinent.GetPosition().y < -5)
        {
            gameContext.FinishGame();
        }
    }
}
