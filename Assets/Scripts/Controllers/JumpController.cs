using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour, IConstructListener,
IStartGameListener,
IFinishGameListener
{
    private KeyboardInput input;
    private IJumpComponent jumpComponent;

    void IConstructListener.Construct(GameContext context)
    {
        input = context.GetService<KeyboardInput>();
        jumpComponent = context.GetService<CharacterService>().GetCharacter().Get<IJumpComponent>();
    }

    void IStartGameListener.OnStartGame()
    {
        this.input.OnJump += Jump;
    }

    void IFinishGameListener.OnFinishGame()
    {
        this.input.OnJump -= Jump;
    }

    private void Jump()
    {
        jumpComponent.Jump();
    }
}
