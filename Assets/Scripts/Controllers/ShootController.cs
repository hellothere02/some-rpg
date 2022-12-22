using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootController : MonoBehaviour, IConstructListener,
IStartGameListener,
IFinishGameListener
{
    private KeyboardInput input;
    private IShootComponent shootComponent;
    void IConstructListener.Construct(GameContext context)
    {
        input = context.GetService<KeyboardInput>();
        shootComponent = context.GetService<CharacterService>().GetCharacter().Get<IShootComponent>();
    }

    void IStartGameListener.OnStartGame()
    {
        this.input.OnShoot += Shoot;
    }

    void IFinishGameListener.OnFinishGame()
    {
        this.input.OnShoot -= Shoot;
    }

    private void Shoot()
    {
        shootComponent.Shoot();
    }
}