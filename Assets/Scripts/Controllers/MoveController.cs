using UnityEngine;


public class MoveController : MonoBehaviour, IConstructListener,
    IStartGameListener,
    IFinishGameListener
{
    private KeyboardInput input;

    private IMoveComponent moveComponent;

    void IConstructListener.Construct(GameContext context)
    {
        input = context.GetService<KeyboardInput>();
        moveComponent = context.GetService<CharacterService>().GetCharacter().Get<IMoveComponent>();
    }

    void IStartGameListener.OnStartGame()
    {
        this.input.OnMove += Move;
    }

    void IFinishGameListener.OnFinishGame()
    {
        this.input.OnMove -= Move;
    }

    private void Move(Vector3 direction)
    {
        const float speed = 5.0f;
        var velocity = direction * (speed * Time.deltaTime);
        this.moveComponent.Move(velocity);
    }
}